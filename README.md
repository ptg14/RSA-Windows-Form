![image](https://github.com/ptg14/RSA-Windows-Form/assets/144470842/11c0b308-5969-431d-9b29-3e8314c13763)


File "RSA_DLL.dll" cần phải trong cùng thư mục với chương trình "RSA_WF.exe".

Các textbox như "Private Key", "Public Key", Ciphert", "Plaintext Decrypt" dùng để nhập tên file sẽ lưu xuống, nếu bỏ trống textbox thì file sẽ được đặt tên mặc định.
Sau khi bấm các nút "GenKey", "Encrypt", "Decrypt" thì các textbox này sẽ được thay bằng đường dẫn đến các file đó.

Các nút "Open" dùng để mở giao diện chọn file.

Plaintext có thể dùng đường dẫn đến file hoặc nhập trực tiếp vào textbox "Plaintext" nếu vậy "Plaintext" sẽ được lưu với tên ngẫu nhiên.

Format khi tạo key, encrypt, decrypt phải giống nhau thì mới có thể decrypt được.
