# ms.NET-AMM

Исторический справочник

Справочник хранит сведения о различных исторических событиях, личностях, организациях, достижениях культурах и т.п.

Виды пользователей:
– Гость: может просматривать существующие записи
– Участник: имеет права Гостя + подавать заявки на дополнение и создание записей
– Редактор: имеет права Участника + одобряет/отклоняет заявки Пользователей
– Администратор: имеет права Редактора + назначает Редакторов

Требования:

1. Регистрация пользователя
    – Гостями сайта считаются незарегистрированные и не залогинившиеся пользователи
    – Гости могут зарегистрироваться, указав электронную почту, имя пользователя и пароль

2. Логин и логаут пользователя
    – Зарегистрировавшийся пользователь может войти в аккаунт, указав почту/имя и пароль
    – Возможно выйти из аккаунта в любой момент
    – При указании почты и имени пользователя возможно восстановить пароль с последующей заменой пароля на новый

3. Просмотр списка записей (INDEX)
    – Любой пользователь может просматривать записи справочника
    – Можно настраивать фильтры: "все записи", записи соответсвующие указанным годам, "связанное с личностью" и т.д.
    – Пользователя уровня "Участник" и выше могут добавлять записи в закладки, выставлять реакции для записи ("Научно!"/"Не научно!")

4. Создание записей (CREATE)
    – Редакторы и Администраторы могут создавать записи
    – Участники могут подавать заявки на создание записей. Записи создаются после предоставления подтверждения исторической достоверности и ценности, и прохождения одобрения от N Редакторов/Администраторов.

5. Просмотр деталей записи (READ)
    – Гости и Участники могут просматривать открытую информацию касаемо каждой записи
    – Редакторы и Администраторы имеют доступ к предложенным, но не одобренным, деталям

6. Редактирование записей (READ)

    – Участники могут вносить изменения, которые добавляются в запись после одобрения Редактора
    – Редакторы и Администраторы могут свободно редактировать записи

7. Удаление записи (DELETE)
    – Редакторы и Администраторы могут выносить вопрос об удалении записи. Запись удаляется только при согласении N Редакторов/Администраторов.



![ms NET](https://github.com/user-attachments/assets/4b477b84-8e28-4e96-a4bd-e3baaf1d8899)

