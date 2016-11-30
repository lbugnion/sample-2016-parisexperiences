# Construisons des application vraiment universelles avec Windows, Xamarin et MVVM

My code samples for the Microsoft Experiences conference in Paris

# Presentation details, Slides, Video

You can see the video recording and the slides here:
http://galasoft.ch/presentations/presentationdetails.cshtml?name=2016021

# Abstract

Avec Windows 10 qui supporte un nombre de plateformes et d'appareils inégalé (depuis l'Internet des Objets jusqu'au SurfaceHub en passant par des téléphones, tablettes, laptop et desktop, XBOX et même la plateforme holographique HoloLens), le nom "Application Universelle Windows" trouve tout son sens. Mais pour être honnête, une application vraiment universelle ne devrait-elle pas également supporter Windows 7, iOS et Android ? Heureusement, c'est possible grâce à l'architecture Model-View-ViewModel (MVVM), les librairies portables de .NET (PCL) et les plateformes Xamarin. Avec ces outils, il est possible de structurer l'application pour partager une grande partie du code, et ensuite de construire des vues utilisateurs natives qui s'adaptent sans compromis à l'appareil sur lequel elles sont exécutées. Laurent Bugnion, un expert en XAML/C#, MVP Microsoft et Xamarin, qui fabriquait des applications universelles avant que ce concept ne soit populaire, vous montrera des informations pratiques avec beaucoup de code. Venez écouter le créateur du populaire MVVM Light Toolkit, il vous montrera comment cette librairie facile d'utilisation peut vous aider à cibler plus d'utilisateurs que vous ne pouvez en rêver.

# Content

## HelloMvvm

Contains an example showing how the "File New Project" experience
of a Xamarin Android app can be refactored to MVVM with
Nuget and MVVM Light, with Data binding and Commanding.

## Flowers

Contains an application developed with MVVM Light 
with Master-Details, Observable Lists (with RecyclerView and ObservableRecyclerAdapter in Android
/ TableView and ObservableTableViewSource in iOS), Data binding, Commanding and more.
