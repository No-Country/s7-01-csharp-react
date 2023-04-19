export function Button({ className, text, click }) {
  return (
    <button
      onClick={click}
      className={`border-[1px] border-solid border-gray-100 rounded-lg flex justify-center items-center p-2 focus:ring active:transform active:translate-y-1  not-italic font-normal ${className}`}
    >
      {text}
    </button>
  );
}
