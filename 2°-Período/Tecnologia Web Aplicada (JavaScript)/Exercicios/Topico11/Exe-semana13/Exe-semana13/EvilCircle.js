import Shape from "./Shape.js";
import { random } from "./util.js";

class EvilCircle extends Shape {
    constructor(x, y, ctx) {
        super(x, y, 20, 20);
        this.color = 'white';
        this.size = 10;
        this.ctx = ctx;
    }

    draw() {
        this.ctx.beginPath();
        this.ctx.strokeStyle = this.color;
        this.ctx.lineWidth = 3;
        this.ctx.arc(this.x, this.y, this.size, 0, 2 * Math.PI);
        this.ctx.stroke();
    }

    checkBounds(width, height) {
        if ((this.x + this.size) >= width) {
            this.x -= this.size;
        }

        if ((this.x + this.size) <= 0) {
            this.x += this.size;
        }

        if ((this.y + this.size) >= height) {
            this.y -= this.size;
        }

        if ((this.y + this.size) <= 0) {
            this.y += this.size;
        }
    }

    setControls() {
        const _this = this;

        window.onkeydown = function (e) {
            if (e.key === 'a') {
                _this.x -= _this.velX;
            } else if (e.key === 'd') {
                _this.x += _this.velX;
            } else if (e.key === 'w') {
                _this.y -= _this.velY;
            } else if (e.key === 's') {
                _this.y += _this.velY;
            }
        };
    }

    collisionDetect(balls, count, para) {
        balls.forEach(vizinha => {
            if (vizinha.exists) {
                const dx = this.x - vizinha.x;
                const dy = this.y - vizinha.y;
                const distance = Math.sqrt(dx * dx + dy * dy);

                if (distance < (this.size + vizinha.size)) {
                    vizinha.exists = false;
                    count--;
                    para.textContent = `Ball count: ${count}`;
                    this.size += 4;
                }
            }
        });
    }
}

export default EvilCircle;
