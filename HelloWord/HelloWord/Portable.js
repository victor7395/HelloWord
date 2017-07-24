function play(url) {
    var request = new XMLHttpRequest();
    if (source) {
        try {
            source.stop();
        }
        catch (err) {
            throw err;
        }
    }
}