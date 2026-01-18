function calculateCost() {
    let from = document.getElementById("from").value;
    let to = document.getElementById("to").value;
    let length = document.getElementById("length").value;
    let width = document.getElementById("width").value;
    let height = document.getElementById("height").value;
    let shippingType = document.getElementById("shippingType").value;
    let result = document.getElementById("result");

    // Validation
    if (
        from === "" ||
        to === "" ||
        length === "" ||
        width === "" ||
        height === "" ||
        shippingType === ""
    ) {
        result.classList.add("text-danger");
        result.innerHTML = "Please fill all fields!";
        return;
    }

    length = Number(length);
    width = Number(width);
    height = Number(height);

    if (length <= 0 || width <= 0 || height <= 0) {
        result.classList.add("text-danger");
        result.innerHTML = "Dimensions must be greater than zero!";
        return;
    }

    let volume = ((length * width * height) / 5000);

    let rate;
    if (shippingType === "air") rate = 0.02;
    else if (shippingType === "sea") rate = 0.01;
    else if (shippingType === "land") rate = 0.015;

    let cost = volume * rate;

    // Save to localStorage
    localStorage.setItem("from", from);
    localStorage.setItem("to", to);
    localStorage.setItem("length", length);
    localStorage.setItem("width", width);
    localStorage.setItem("height", height);
    localStorage.setItem("shippingType", shippingType);

    result.classList.remove("text-danger");
    result.innerHTML =
        "Shipment from <strong>" +
        from +
        "</strong> to <strong>" +
        to +
        "</strong><br>" +
        "Estimated Shipping Cost: <strong>$" +
        cost.toFixed(2) +
        " </strong>";
}

// Load saved values after refresh
window.onload = function () {
    if (localStorage.getItem("from")) {
        document.getElementById("from").value = localStorage.getItem("from");
        document.getElementById("to").value = localStorage.getItem("to");
        document.getElementById("length").value = localStorage.getItem("length");
        document.getElementById("width").value = localStorage.getItem("width");
        document.getElementById("height").value = localStorage.getItem("height");
        document.getElementById("shippingType").value =
            localStorage.getItem("shippingType");
    }
};