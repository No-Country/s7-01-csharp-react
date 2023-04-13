/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      fontFamily: {
        poppins: ["Poppins", "sans-serif"],
      },
      colors: {
        white: "#ffffff",
        "gray-50": "#ebebeb",
        "bg-color": "#f5f5f5",
        "gray-100": "#999ca0",
        "gray-150": "#656565",
        "primary-100": "#1558d6",
        "primary-50": "#e8f0fe",
        "primary-150": "#5c9ce8",
        "secondary-50": "#a4d0c0",
        "secondary-100": "#488c73",
        error: "#ff4e64",
      },
    },
  },
  plugins: [],
};
