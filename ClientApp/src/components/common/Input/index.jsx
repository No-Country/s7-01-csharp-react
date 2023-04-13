export function Input({ className, placeholder, value, onChange, type }) {
  return (
    <input
      className={`appearance-none border rounded-lg w-full py-2 px-3 text-gray-100 leading-tight focus:outline-none focus:shadow-outline focus:border-blue-500 ${className}`}
      type={type}
      placeholder={placeholder}
    />
  );
}
