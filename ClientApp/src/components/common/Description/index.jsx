export function Description({ className, content }) {
  return <p className={`not-italic font-normal ${className}`}>{content}</p>;
}
