چند نکته :
1- در نامگذاری Command‌ها، کلمه Command در انتهای نام آن‌ها آورده میشود؛ مثال: CreateCustomerCommand
2- در نامگذاری Query‌ها، کلمه Query در انتهای نام آن‌ها آورده میشود؛ مثال : GetCustomerByIdQuery
3- در نامگذاری Handler‌ها، از ترکیب Command/Query + Handler استفاده میکنیم؛ مثال : CreateCustomerCommandHandler, GetCustomerByIdQueryHandler
4- در این قسمت Request‌های ما بدون هیچ Validation ای وارد Handler هایشان میشدند که این نیاز اکثر برنامه‌ها نیست. در قسمت بعدی با استفاده از Fluent Validation پارامترهای Request هایمان را بطور خودکار اعتبارسنجی میکنیم.