# EasyLanguageLearningKata

Easy language learning, a language teaching company, contacted us to build their app.
Their current language catalog includes:
*	English
*	French
*	Spanish
*	German

After several meetings we got the following user stories.

## Choosing a course

> As a student of ELL I want to choose a course to learn a new language from my mother language.

Acceptance criteria:
*	Mother language and learning language must be different.
*	Any language in the app must be in the current language catalog.
*	Course name has Learning language and number (French 3, Spanish 2, etc).
*	Language name should be display in mother language.
*	Currently course’s go from 1 to 3.

## View unit’s content

Every course has many units of content. Content is made of words or sentences translated to the learning language.

> As ELL student I want to view a unit’s content summary to have all content translated to the course’s learning language in a single list.

Acceptance criteria:
* Content list should not contain repeated language translations.
* Each item on the summary list should display content on mother language and it’s translation.
* All units must belong to a course.
* No content of a unit can have any language that is not in the current course.

## Writing exercise

> As a student of ELL I want my knowledge tested though a writing exercise by translating  a language term.

Acceptance criteria:
*	If the translation is accurate ‘well done' should be promoted.
*	If the translation is mostly correct ‘almost’ and the correct answer should be promoted
*	If the translation is wrong ‘wrong answer’ and the correct answer should be promoted
 
## Multiple choice

> As a student of ELL I want my knowledge tested though multiple choice exercises.

Acceptance criteria:
*	A single language term should be shown either from mother language or learning language, play the role of a question.
*	4 choices should be shown, only one of theme is correct.
*	Immediately after answering the multiple choice exercise the answer result should be displayed. (right or wrong)

## Writing tips

A tip is an auto completed letter from the language term.

> As a student of ELL I want ask for tips when completing writing exercises in other to trigger my memory.

Acceptance criteria:
*	Tips cannot excide half of the length of the language term.

## List of unit names

> As a student of ELL I want a list of all units belonging to a course so when a course is selected I can have an idea of what it’s units are about.

Acceptance criteria:
* Unit name should be displayed per each item of the list.

## Course progress

> As a student of ELL I want to know my level of completion so that I can know how much of the current course I have gone through.

Acceptance criteria:
* Percentage of completion should be displayed when entering a course.

## Pick up where I left off

> As a student of ELL I want to resume my course headway where I left off.

Acceptance criteria:
* When a user acceses the system their last accessed course’s lessons should be loaded.

