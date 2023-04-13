export function Information({ className, children }) {
  return (
    <div
      className={`border-0 p-0 border-solid border-[#999CA0] rounded-lg flex flex-col gap-2`}
    >
      {children}
    </div>
  );
}
