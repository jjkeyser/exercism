
export const isArmstrongNumber = (num) => {
  let numString = num.toString();
  let power = numString.length;
  let sum = 0;

  for (let i = 0; i < power; i++) {
    sum += Math.pow(Number(numString[i]), power);
  }

  return num === sum;
};
