/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {

     fontFamily: {
    //   sans: ['Graphik', 'sans-serif'],
    //   serif: ['Merriweather', 'serif'],
    poppins:['Poppins',"sans-serif"]
    },
    colors: {
      'white': '#ffffff',
      'gray-50': '#ebebeb',
      'bg-color': '#f5f5f5',
      'grey-100': '#999ca0',
      'grey-150': '#656565',
      'primary-100': '#1558d6',
      'primary-50': '#e8f0fe',
      'primary-150': '#5c9ce8',
      'secondary-50': '#a4d0c0',
      'secondary-100': '#488c73',
      'error': '#ff4e64'
    },
    extend: {
      // spacing: {
      //   '8xl': '96rem',
      //   '9xl': '128rem',
      // },
      // borderRadius: {
      //   '4xl': '2rem',
      // }
    },
  },
  plugins: [],
};
