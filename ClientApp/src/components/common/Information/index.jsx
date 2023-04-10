import { Description } from "../Description";
import { Title } from "../Title";

export function Information({ className, title, description }) {
  return (
    <div
      className={`p-4 border-[1px] border-solid border-[#999CA0] rounded-lg flex flex-col gap-2 ${className}`}
    >
      <Title content={title} />
      <Description content={description} />
    </div>
  );
}
