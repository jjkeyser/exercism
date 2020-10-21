
export const isArmstrongNumber = (num) => {
  return num.toString()
            .split('')
            .map(a => Math.pow(Number(a), num.toString().length))
            .reduce((a, b) => a + b) === num;
};
