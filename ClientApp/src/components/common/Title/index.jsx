export function Title({ className, content }) {
  return (
    <h2 className={`text-black not-italic font-medium ${className}`}>
      {content}
    </h2>
  );
}
