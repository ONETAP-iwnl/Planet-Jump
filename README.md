Игра на IOS / Android в разработке

Как получить с репозитория:
1. Переходим в гитхаб десктоп;
2. Выбираем наш репозиторий;
3. Сверху будет кнопка Repository;
4. Выпололзает окно и нажимаем "Pull" (pull - вытянуть).

Cтарайтесь писать на английском, если не можете не надо.

Перед отправкой коммита, пишите : feat, chore, docs(в зависимости что вы сделали, ниже описал).
- feat: Сообщение с описанием и нижним колонтитулом критических изменений
	Пример: 
	feat: allow provided config object to extend other configs
	BREAKING CHANGE: `extends` key in config file is now used for extending other config files

	Можете в скобочках писать над чем именно.
	feat(api)!: send an email to the customer when a product is shipped -- Сообщение фиксации с областью действия и ! привлечь внимание к критическим изменениям.

- feat!: Зафиксировать сообщение с помощью ! привлечь внимание к критическим изменениям.
	Пример: 
	feat!: send an email to the customer when a product is shipped.

- chore!: Зафиксируйте сообщение с обоими! и нижний колонтитул «КРАТКОЕ ИЗМЕНЕНИЕ». Проще говоря микроизменения и про них написать надо.
	Пример: 
	chore!: drop support for Node 6 

- docs: Зафиксировать сообщение без тела.
	Пример:
	docs: correct spelling of CHANGELOG

	Можете здесь прочитать - https://www.conventionalcommits.org/ru/v1.0.0/

Это пригодиться, потом можно будет автоматически создавать список изменений.
