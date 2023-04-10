export function Button({ className, text }) {
  return (
    <button
      className={`border-[1px] border-solid border-gray-100 rounded-lg flex justify-center items-center p-2 focus:ring active:transform active:translate-y-1 ${className}`}
    >
      <p className="text-black not-italic font-normal text-sm">{text}</p>
    </button>
  );
}
