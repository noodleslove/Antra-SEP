function truncate(str, maxLength) {
  return str.length > maxLength ? str.slice(0, maxLength - 1) + "..." : str;
}

console.log(
  truncate("What I'd like to tell on this topic is:", 20) ===
    "What I'd like to te..."
); // true
console.log(truncate("Hi everyone!", 20) === "Hi everyone!"); // true
