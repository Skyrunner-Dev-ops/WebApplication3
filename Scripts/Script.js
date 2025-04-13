let currentId = 1;
let completed = false;
var Username = '';
// Load question by ID from the server
function loadQuestion(id) {
    $.get('/Quiz/GetQuestion', { id: id }, function (data) {
        if (data.done) {
            $('#questionText').text("Calculating your spirit animal...");
            $('#optionsContainer').html(""); // optional: show loading spinner
            return;
        }

        // Set the question text
        $('#questionText').text(data.text);

        // Build options dynamically
        let html = '';
        data.options.forEach((opt, index) => {
            html += `
                <div>
                    <input type="radio" name="option" id="opt${index}" value="${opt.traits}" />
                    <label for="opt${index}">${opt.text}</label>
                </div>
            `;
        });

        // Add "Next" button
        //html += `<button onclick="submitAnswer()">Next</button>`;

        // Render options into the container
        $('#optionsContainer').html(html);
    });
}

// Submit selected answer and go to next question or result
function submitAnswer() {
    if (completed) { location.reload(); return; }
    const selected = $('input[name="option"]:checked').val();

    if (!selected && !completed) {
        alert("Please select an option.");
        return;
    }

    $.post('/Quiz/SubmitAnswer', {
        questionId: currentId,
        selectedTraits: selected
    }, function (result) {
        if (result.done) {

            if(Username.toLowerCase() == 'prabhat')
            {
                $('#questionText').text("Spirit animal of " + Username + " is: Donkey");
                $("#Animal_image").attr("src", "/Content/Donkey.png").removeAttr("hidden");
                $('#optionsContainer').html("");
                completed = true;
                $('#Submit_Btn').html("Try Again");
                return;
            }

            if (Username.toLowerCase() == 'priyanshi') {
                $('#questionText').text("Spirit animal of " + Username + " is: Panda");
                $("#Animal_image").attr("src", "/Content/Panda.png").removeAttr("hidden");
                $('#optionsContainer').html("");
                completed = true;
                $('#Submit_Btn').html("Try Again");
                return;
            }

            // Show the result (final animal)
            $('#questionText').text("Spirit animal of " + Username +" is: " + result.animal);
            $("#Animal_image").attr("src", "/Content/" + result.animal +".png").removeAttr("hidden");
            $('#optionsContainer').html("");
            completed = true;
            $('#Submit_Btn').html("Try Again");//.click(function () { location.reload() });
            
        } else {

            // Move to the next question
            currentId = result.nextId;
            loadQuestion(currentId);
        }
    });
}

// Initial load
$(document).ready(function () {
    loadQuestion(currentId);
    
    $('#Start_btn').click(function () {
        var User = $('#userName').val().trim();
        if (User) {
            Username = User;
            $('.intro').fadeOut(500, function () {
                $('.quiz-container').removeAttr('hidden')
                $('.quiz-container').fadeIn(500);
            });
        } else {
            alert('Enter your name');
        }

    });


});
