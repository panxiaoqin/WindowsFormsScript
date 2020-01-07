function win_click(x, y) {
    runtime.click(parseInt(x), parseInt(y));
}

function win_input(content, time) {
    runtime.input(content, parseInt(time));
}

function win_sleep(time) {
    runtime.sleep(parseInt(time));
}

function win_select(app) {
    runtime.selectApp(app);
}

function win_script(fun) {
    eval(fun + "()");
}