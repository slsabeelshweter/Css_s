const sendBtn = document.querySelector(".btn-send");

sendBtn.addEventListener("click", function () {
    const form = document.getElementById("contactForm");
    const message = form.querySelector("textarea").value;
    const firstName = form.querySelector('input[type="text"]:first-of-type').value;
    const lastName = form.querySelector('input[type="text"]:last-of-type').value;
    const phone = form.querySelector('input[type="tel"]').value;
    const email = form.querySelector('input[type="email"]').value;

    const data = { message, firstName, lastName, phone, email };

    fetch("https://6947b569ca6715d122fadc09.mockapi.io/users", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
    })
        .then(res => res.json())
        .then(() => {
            alert("✅ Message sent successfully!");
            form.reset();
        })
        .catch(() => alert("❌ Error sending message"));
});
