function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

// Отримуємо елементи
const videoModal = document.getElementById('videoModal');
const videoFrame = document.getElementById('video');

// Слухач на відкриття модального вікна
videoModal.addEventListener('show.bs.modal', function (event) {
    // Вказуємо URL відео (використовуємо правильний embed URL)
    const videoUrl = "https://www.youtube.com/embed/hOVd_PdJDb0?autoplay=1";
    videoFrame.src = videoUrl;
});

// Слухач на закриття модального вікна
videoModal.addEventListener('hidden.bs.modal', function () {
    // Очистимо URL відео, щоб зупинити його відтворення
    videoFrame.src = "";
});