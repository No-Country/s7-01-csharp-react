export function Information({ className, children }) {
  return (
    <div className={`border-solid rounded-lg flex flex-col gap-2 ${className}`}>
      {children}
    </div>
  );
}
