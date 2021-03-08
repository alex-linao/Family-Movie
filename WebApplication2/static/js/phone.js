UA = navigator.userAgent.toLowerCase();
url = window.location;
url = url.toString();
if ((UA.indexOf('iphone') != -1 || UA.indexOf('mobile') != -1 || UA.indexOf('android') != -1 || UA.indexOf('ipad') != -1 || UA.indexOf('windows ce') != -1 || UA.indexOf('ipod') != -1) && UA.indexOf('ipod') == -1) {
    if (url.indexOf("wap.") < 0) {
        if (url.indexOf("www.") < 0) {
            var index = url.indexOf("http://");
            if (index < 0) {
                url = "wap." + url;
            } else {
                url = url.replace("http://", "http://wap.");
            }
        } else {
            url = url.replace("www.", "wap.");
        }
        Go(url);
    }
}
function Go(url) {
    window.location = url;
}