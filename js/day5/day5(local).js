let input = document.getElementById("textInput");

        if (localStorage.getItem("savedText") !== null) {
            input.value = localStorage.getItem("savedText");
        }

        function saveText() {
            localStorage.setItem("savedText", input.value);
        }

        function deleteText() {
            input.value = "";
            localStorage.removeItem("savedText");
        }