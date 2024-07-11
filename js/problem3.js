function checkEmailId(str) {
  let emailPattern = /^[^\.]*@[a-zA-Z0-9.-]+\..*$/;
  return emailPattern.test(str);
}

console.log(`apple_everyday@doctor.com => ${checkEmailId("apple_everyday@doctor.com")}`); // true
console.log(`apple.everyday@doctor.com => ${checkEmailId("apple.everyday@doctor.com")}`); // false
console.log(`apple.everyday@doctor => ${checkEmailId("apple.everyday@doctor")}`); // false
