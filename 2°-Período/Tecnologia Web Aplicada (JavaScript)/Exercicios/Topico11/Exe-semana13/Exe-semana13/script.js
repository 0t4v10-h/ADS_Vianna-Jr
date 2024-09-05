import EvilCircle from "./EvilCircle.js";
import Ball from "./Ball.js";
import { random } from "./util.js";

// setup canvas
const canvas = document.querySelector("canvas");
const ctx = canvas.getContext("2d");

const width = canvas.width = window.innerWidth;
const height = canvas.height = window.innerHeight;

// other necessary code...

let balls = [];
let count = 25;
let para = document.querySelector('h1');

while (balls.length < count) {
    const size = random(10, 20);
    const color = randomRGB();
    let ball = new Ball(
        random(0 + size, width - size),
        random(0 + size, height - size),
        random(-7, 7),
        random(-7, 7),
        color,
        size,
        ctx
    );

    balls.push(ball);
}

let evil = new EvilCircle(random(0, width - 10), random(0, height - 10), ctx);
evil.setControls();

function loop() {
    ctx.fillStyle = 'rgba(0,0,0,0.25)';
    ctx.fillRect(0, 0, width, height);

    balls.forEach(ball => {
        if (ball.exists) {
            ball.draw();
            ball.update(width, height);
            ball.collisionDetect(balls);
        }
    });

    evil.draw();
    evil.checkBounds(width, height);
    evil.collisionDetect(balls, count, para);

    requestAnimationFrame(loop);
}

loop();
