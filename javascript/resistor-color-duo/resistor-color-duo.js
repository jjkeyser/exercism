
export const decodedValue = (colors) => {
    return (getIndexOfColor(colors[0]) * 10) + getIndexOfColor(colors[1]);
};

export const COLORS = ['black', 'brown', 'red', 'orange', 'yellow', 'green', 'blue', 'violet', 'grey', 'white'];

function getIndexOfColor(color) {
    return COLORS.indexOf(color);
}