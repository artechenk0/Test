   M S B A M L   `   `   `  ????  EyesSave    EyesSave.Pages.ViewAgents   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N? Title$!  Список агентов??5      .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??0??6.   $??Center=?6;   .+?5      ?? $??Поиск:??6   $??5q?6&   $??Center=?61   ?? 5      -   5         ??Name$ 	SearchBox??5   :   $	??300??6M   $??5q?6\   ?? 5      -   5        $??TypeBox??5       ?? SelectedIndex$ 0??6R    ?? DisplayMemberPath$ Title??6d   $	??120??6~   $??5q?6?   ?? 5      -   5        $??SortBox??5      $	??120??6R   $??5q?6a   5      ?? 5   
   -   5        $??AgentsLV??5       $??1??6   $??Disabled=?60   ??5      ?? 5      .R?5      ? $??5q?6   .+?5      ?? $ 
Horizontal=?6%   $
??Left=?6>   .+?5      ?? $??80??6$   $??5q?6/   ??5   "   ?? 5    &    ?? Path$
 Logo?6.    ?? TargetNullValue 5!   *   ??5"   .   /Resource/picture.png??5%   /   5'   '   5)      ?? 5+      $ Vertical=?6)   .+?5,   "   ?? $ 
Horizontal=?6-   .+?5-   &   ?? ??60   ?? *AgentType.Title+?? 5.   &   $	?? | ??60   ?? 5/   &   ??60   ?? *Title+50   #   ?? 52   "   ??6,   ?? *ProductSale.Count+ ?? StringFormat$) #Продуктов за год: {0}???? 53   "   ??6,   ?? *Phone+?? 54   "   ??6,   ?? *
Priority+$ Приоритет: {0}??55      56      57      58      5:      ?? 5;   
   -   5        	 ??Name$	 BtnAdd??5;      $??Добавить??6!   $??Center=?64   $??Right=?6O   $??2??6k   $??10q?6x   $	??100??6?   5<      5=      