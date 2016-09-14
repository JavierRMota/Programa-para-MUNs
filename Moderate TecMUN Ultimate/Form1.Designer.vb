<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Topic = New System.Windows.Forms.Label()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Dots = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.Label()
        Me.NowSpeaking = New System.Windows.Forms.GroupBox()
        Me.NSL = New System.Windows.Forms.Label()
        Me.flag = New System.Windows.Forms.PictureBox()
        Me.NextSpeaker = New System.Windows.Forms.GroupBox()
        Me.NS3L = New System.Windows.Forms.Label()
        Me.NS2L = New System.Windows.Forms.Label()
        Me.NS1L = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Flags = New System.Windows.Forms.ImageList(Me.components)
        Me.counterd = New System.Windows.Forms.Label()
        Me.SLT = New System.Windows.Forms.Label()
        Me.Committee = New System.Windows.Forms.Label()
        Me.President = New System.Windows.Forms.Label()
        Me.Question1 = New System.Windows.Forms.Label()
        Me.Question2 = New System.Windows.Forms.Label()
        Me.Question3 = New System.Windows.Forms.Label()
        Me.Question4 = New System.Windows.Forms.Label()
        Me.Question5 = New System.Windows.Forms.Label()
        Me.SO4 = New System.Windows.Forms.Label()
        Me.NowSpeaking.SuspendLayout()
        CType(Me.flag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NextSpeaker.SuspendLayout()
        Me.SuspendLayout()
        '
        'Topic
        '
        Me.Topic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Topic.AutoSize = True
        Me.Topic.BackColor = System.Drawing.Color.Transparent
        Me.Topic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Topic.Location = New System.Drawing.Point(17, 46)
        Me.Topic.Name = "Topic"
        Me.Topic.Size = New System.Drawing.Size(0, 17)
        Me.Topic.TabIndex = 0
        '
        'Minutes
        '
        Me.Minutes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minutes.AutoSize = True
        Me.Minutes.BackColor = System.Drawing.Color.Transparent
        Me.Minutes.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Minutes.Location = New System.Drawing.Point(71, 279)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(103, 78)
        Me.Minutes.TabIndex = 1
        Me.Minutes.Text = "00"
        '
        'Seconds
        '
        Me.Seconds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seconds.AutoSize = True
        Me.Seconds.BackColor = System.Drawing.Color.Transparent
        Me.Seconds.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Seconds.Location = New System.Drawing.Point(180, 279)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(103, 78)
        Me.Seconds.TabIndex = 2
        Me.Seconds.Text = "00"
        '
        'Dots
        '
        Me.Dots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dots.AutoSize = True
        Me.Dots.BackColor = System.Drawing.Color.Transparent
        Me.Dots.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dots.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dots.Location = New System.Drawing.Point(153, 279)
        Me.Dots.Name = "Dots"
        Me.Dots.Size = New System.Drawing.Size(51, 78)
        Me.Dots.TabIndex = 3
        Me.Dots.Text = ":"
        '
        'State
        '
        Me.State.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.State.AutoSize = True
        Me.State.BackColor = System.Drawing.Color.Transparent
        Me.State.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.State.Location = New System.Drawing.Point(36, 207)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(321, 58)
        Me.State.TabIndex = 4
        Me.State.Text = "Speaker's List"
        '
        'NowSpeaking
        '
        Me.NowSpeaking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NowSpeaking.BackColor = System.Drawing.Color.Transparent
        Me.NowSpeaking.Controls.Add(Me.NSL)
        Me.NowSpeaking.Controls.Add(Me.flag)
        Me.NowSpeaking.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NowSpeaking.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NowSpeaking.Location = New System.Drawing.Point(418, 70)
        Me.NowSpeaking.Name = "NowSpeaking"
        Me.NowSpeaking.Size = New System.Drawing.Size(545, 256)
        Me.NowSpeaking.TabIndex = 5
        Me.NowSpeaking.TabStop = False
        Me.NowSpeaking.Text = "Now Speaking"
        '
        'NSL
        '
        Me.NSL.AutoSize = True
        Me.NSL.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NSL.Location = New System.Drawing.Point(32, 62)
        Me.NSL.Name = "NSL"
        Me.NSL.Size = New System.Drawing.Size(0, 39)
        Me.NSL.TabIndex = 1
        '
        'flag
        '
        Me.flag.Location = New System.Drawing.Point(39, 137)
        Me.flag.Name = "flag"
        Me.flag.Size = New System.Drawing.Size(203, 100)
        Me.flag.TabIndex = 0
        Me.flag.TabStop = False
        '
        'NextSpeaker
        '
        Me.NextSpeaker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextSpeaker.BackColor = System.Drawing.Color.Transparent
        Me.NextSpeaker.Controls.Add(Me.SO4)
        Me.NextSpeaker.Controls.Add(Me.NS3L)
        Me.NextSpeaker.Controls.Add(Me.NS2L)
        Me.NextSpeaker.Controls.Add(Me.NS1L)
        Me.NextSpeaker.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextSpeaker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NextSpeaker.Location = New System.Drawing.Point(418, 332)
        Me.NextSpeaker.Name = "NextSpeaker"
        Me.NextSpeaker.Size = New System.Drawing.Size(545, 262)
        Me.NextSpeaker.TabIndex = 6
        Me.NextSpeaker.TabStop = False
        Me.NextSpeaker.Text = "Next Speakers"
        '
        'NS3L
        '
        Me.NS3L.AutoSize = True
        Me.NS3L.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NS3L.Location = New System.Drawing.Point(32, 159)
        Me.NS3L.Name = "NS3L"
        Me.NS3L.Size = New System.Drawing.Size(0, 39)
        Me.NS3L.TabIndex = 4
        '
        'NS2L
        '
        Me.NS2L.AutoSize = True
        Me.NS2L.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NS2L.Location = New System.Drawing.Point(32, 106)
        Me.NS2L.Name = "NS2L"
        Me.NS2L.Size = New System.Drawing.Size(0, 39)
        Me.NS2L.TabIndex = 3
        '
        'NS1L
        '
        Me.NS1L.AutoSize = True
        Me.NS1L.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NS1L.Location = New System.Drawing.Point(32, 56)
        Me.NS1L.Name = "NS1L"
        Me.NS1L.Size = New System.Drawing.Size(0, 39)
        Me.NS1L.TabIndex = 2
        '
        'Time
        '
        Me.Time.Interval = 1000
        '
        'Flags
        '
        Me.Flags.ImageStream = CType(resources.GetObject("Flags.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Flags.TransparentColor = System.Drawing.Color.Transparent
        Me.Flags.Images.SetKeyName(0, "Afghanistan.png")
        Me.Flags.Images.SetKeyName(1, "Albania.png")
        Me.Flags.Images.SetKeyName(2, "Algeria.png")
        Me.Flags.Images.SetKeyName(3, "American Samoa.png")
        Me.Flags.Images.SetKeyName(4, "Andorra.png")
        Me.Flags.Images.SetKeyName(5, "Angola.png")
        Me.Flags.Images.SetKeyName(6, "Anguilla.png")
        Me.Flags.Images.SetKeyName(7, "Antigua and Barbuda.png")
        Me.Flags.Images.SetKeyName(8, "Argentina.png")
        Me.Flags.Images.SetKeyName(9, "Armenia.png")
        Me.Flags.Images.SetKeyName(10, "Aruba.png")
        Me.Flags.Images.SetKeyName(11, "Australia.png")
        Me.Flags.Images.SetKeyName(12, "Austria.png")
        Me.Flags.Images.SetKeyName(13, "Azerbaijan.png")
        Me.Flags.Images.SetKeyName(14, "Bahamas.png")
        Me.Flags.Images.SetKeyName(15, "Bahrain.png")
        Me.Flags.Images.SetKeyName(16, "Bangladesh.png")
        Me.Flags.Images.SetKeyName(17, "Barbados.png")
        Me.Flags.Images.SetKeyName(18, "Belarus.png")
        Me.Flags.Images.SetKeyName(19, "Belgium.png")
        Me.Flags.Images.SetKeyName(20, "Belize.png")
        Me.Flags.Images.SetKeyName(21, "Benin.png")
        Me.Flags.Images.SetKeyName(22, "Bermuda.png")
        Me.Flags.Images.SetKeyName(23, "Bhutan.png")
        Me.Flags.Images.SetKeyName(24, "Bolivia.png")
        Me.Flags.Images.SetKeyName(25, "Bosnia.png")
        Me.Flags.Images.SetKeyName(26, "Botswana.png")
        Me.Flags.Images.SetKeyName(27, "Brazil.png")
        Me.Flags.Images.SetKeyName(28, "British Virgin Islands.png")
        Me.Flags.Images.SetKeyName(29, "Brunei.png")
        Me.Flags.Images.SetKeyName(30, "Bulgaria.png")
        Me.Flags.Images.SetKeyName(31, "Burkina Faso.png")
        Me.Flags.Images.SetKeyName(32, "Burundi.png")
        Me.Flags.Images.SetKeyName(33, "Cambodia.png")
        Me.Flags.Images.SetKeyName(34, "Cameroon.png")
        Me.Flags.Images.SetKeyName(35, "Canada.png")
        Me.Flags.Images.SetKeyName(36, "Cape Verde.png")
        Me.Flags.Images.SetKeyName(37, "Cayman Islands.png")
        Me.Flags.Images.SetKeyName(38, "Central African Republic.png")
        Me.Flags.Images.SetKeyName(39, "Chad.png")
        Me.Flags.Images.SetKeyName(40, "Chile.png")
        Me.Flags.Images.SetKeyName(41, "China.png")
        Me.Flags.Images.SetKeyName(42, "Christmas Island.png")
        Me.Flags.Images.SetKeyName(43, "Colombia.png")
        Me.Flags.Images.SetKeyName(44, "Comoros.png")
        Me.Flags.Images.SetKeyName(45, "Cook Islands.png")
        Me.Flags.Images.SetKeyName(46, "Costa Rica.png")
        Me.Flags.Images.SetKeyName(47, "Côte d'Ivoire.png")
        Me.Flags.Images.SetKeyName(48, "Croatia.png")
        Me.Flags.Images.SetKeyName(49, "Cuba.png")
        Me.Flags.Images.SetKeyName(50, "Cyprus.png")
        Me.Flags.Images.SetKeyName(51, "Cyprus Northern.png")
        Me.Flags.Images.SetKeyName(52, "Czech Republic.png")
        Me.Flags.Images.SetKeyName(53, "Denmark.png")
        Me.Flags.Images.SetKeyName(54, "Djibouti.png")
        Me.Flags.Images.SetKeyName(55, "Dominica.png")
        Me.Flags.Images.SetKeyName(56, "Dominican Republic.png")
        Me.Flags.Images.SetKeyName(57, "Ecuador.png")
        Me.Flags.Images.SetKeyName(58, "Egypt.png")
        Me.Flags.Images.SetKeyName(59, "El Salvador.png")
        Me.Flags.Images.SetKeyName(60, "Equatorial Guinea.png")
        Me.Flags.Images.SetKeyName(61, "Eritrea.png")
        Me.Flags.Images.SetKeyName(62, "Estonia.png")
        Me.Flags.Images.SetKeyName(63, "Ethiopia.png")
        Me.Flags.Images.SetKeyName(64, "Falkland Islands.png")
        Me.Flags.Images.SetKeyName(65, "Faroe Islands.png")
        Me.Flags.Images.SetKeyName(66, "Fiji.png")
        Me.Flags.Images.SetKeyName(67, "Finland.png")
        Me.Flags.Images.SetKeyName(68, "France.png")
        Me.Flags.Images.SetKeyName(69, "French Polynesia.png")
        Me.Flags.Images.SetKeyName(70, "Gabon.png")
        Me.Flags.Images.SetKeyName(71, "Gambia.png")
        Me.Flags.Images.SetKeyName(72, "Georgia.png")
        Me.Flags.Images.SetKeyName(73, "Germany.png")
        Me.Flags.Images.SetKeyName(74, "Ghana.png")
        Me.Flags.Images.SetKeyName(75, "Gibraltar.png")
        Me.Flags.Images.SetKeyName(76, "Greece.png")
        Me.Flags.Images.SetKeyName(77, "Greenland.png")
        Me.Flags.Images.SetKeyName(78, "Grenada.png")
        Me.Flags.Images.SetKeyName(79, "Guam.png")
        Me.Flags.Images.SetKeyName(80, "Guatemala.png")
        Me.Flags.Images.SetKeyName(81, "Guinea.png")
        Me.Flags.Images.SetKeyName(82, "Guinea Bissau.png")
        Me.Flags.Images.SetKeyName(83, "Guyana.png")
        Me.Flags.Images.SetKeyName(84, "Honduras.png")
        Me.Flags.Images.SetKeyName(85, "Hong Kong.png")
        Me.Flags.Images.SetKeyName(86, "Hungary.png")
        Me.Flags.Images.SetKeyName(87, "Iceland.png")
        Me.Flags.Images.SetKeyName(88, "India.png")
        Me.Flags.Images.SetKeyName(89, "Indonesia.png")
        Me.Flags.Images.SetKeyName(90, "Iran.png")
        Me.Flags.Images.SetKeyName(91, "Ireland.png")
        Me.Flags.Images.SetKeyName(92, "Israel.png")
        Me.Flags.Images.SetKeyName(93, "Italy.png")
        Me.Flags.Images.SetKeyName(94, "Jamaica.png")
        Me.Flags.Images.SetKeyName(95, "Japan.png")
        Me.Flags.Images.SetKeyName(96, "Jordan.png")
        Me.Flags.Images.SetKeyName(97, "Kazakhstan.png")
        Me.Flags.Images.SetKeyName(98, "Kenya.png")
        Me.Flags.Images.SetKeyName(99, "Kiribati.png")
        Me.Flags.Images.SetKeyName(100, "Kuwait.png")
        Me.Flags.Images.SetKeyName(101, "Kyrgyzstan.png")
        Me.Flags.Images.SetKeyName(102, "Laos.png")
        Me.Flags.Images.SetKeyName(103, "Latvia.png")
        Me.Flags.Images.SetKeyName(104, "Lebanon.png")
        Me.Flags.Images.SetKeyName(105, "Lesotho.png")
        Me.Flags.Images.SetKeyName(106, "Liberia.png")
        Me.Flags.Images.SetKeyName(107, "Liechtenstein.png")
        Me.Flags.Images.SetKeyName(108, "Lithuania.png")
        Me.Flags.Images.SetKeyName(109, "Luxembourg.png")
        Me.Flags.Images.SetKeyName(110, "Macao.png")
        Me.Flags.Images.SetKeyName(111, "Macedonia.png")
        Me.Flags.Images.SetKeyName(112, "Madagascar.png")
        Me.Flags.Images.SetKeyName(113, "Malawi.png")
        Me.Flags.Images.SetKeyName(114, "Malaysia.png")
        Me.Flags.Images.SetKeyName(115, "Maldives.png")
        Me.Flags.Images.SetKeyName(116, "Mali.png")
        Me.Flags.Images.SetKeyName(117, "Malta.png")
        Me.Flags.Images.SetKeyName(118, "Marshall Islands.png")
        Me.Flags.Images.SetKeyName(119, "Martinique.png")
        Me.Flags.Images.SetKeyName(120, "Mauritania.png")
        Me.Flags.Images.SetKeyName(121, "Mauritius.png")
        Me.Flags.Images.SetKeyName(122, "Mexico.png")
        Me.Flags.Images.SetKeyName(123, "Micronesia.png")
        Me.Flags.Images.SetKeyName(124, "Moldova.png")
        Me.Flags.Images.SetKeyName(125, "Monaco.png")
        Me.Flags.Images.SetKeyName(126, "Mongolia.png")
        Me.Flags.Images.SetKeyName(127, "Montserrat.png")
        Me.Flags.Images.SetKeyName(128, "Morocco.png")
        Me.Flags.Images.SetKeyName(129, "Mozambique.png")
        Me.Flags.Images.SetKeyName(130, "Myanmar.png")
        Me.Flags.Images.SetKeyName(131, "Namibia.png")
        Me.Flags.Images.SetKeyName(132, "Nauru.png")
        Me.Flags.Images.SetKeyName(133, "Nepal.png")
        Me.Flags.Images.SetKeyName(134, "Netherlands.png")
        Me.Flags.Images.SetKeyName(135, "Netherlands Antilles.png")
        Me.Flags.Images.SetKeyName(136, "New Zealand.png")
        Me.Flags.Images.SetKeyName(137, "Nicaragua.png")
        Me.Flags.Images.SetKeyName(138, "Niger.png")
        Me.Flags.Images.SetKeyName(139, "Nigeria.png")
        Me.Flags.Images.SetKeyName(140, "Niue.png")
        Me.Flags.Images.SetKeyName(141, "Norfolk Island.png")
        Me.Flags.Images.SetKeyName(142, "Democratic Republic of Korea.png")
        Me.Flags.Images.SetKeyName(143, "Norway.png")
        Me.Flags.Images.SetKeyName(144, "Oman.png")
        Me.Flags.Images.SetKeyName(145, "Pakistan.png")
        Me.Flags.Images.SetKeyName(146, "Palau.png")
        Me.Flags.Images.SetKeyName(147, "Panama.png")
        Me.Flags.Images.SetKeyName(148, "Papua New Guinea.png")
        Me.Flags.Images.SetKeyName(149, "Paraguay.png")
        Me.Flags.Images.SetKeyName(150, "Peru.png")
        Me.Flags.Images.SetKeyName(151, "Philippines.png")
        Me.Flags.Images.SetKeyName(152, "Pitcairn Islands.png")
        Me.Flags.Images.SetKeyName(153, "Poland.png")
        Me.Flags.Images.SetKeyName(154, "Portugal.png")
        Me.Flags.Images.SetKeyName(155, "Puerto Rico.png")
        Me.Flags.Images.SetKeyName(156, "Qatar.png")
        Me.Flags.Images.SetKeyName(157, "Republic of the Congo.png")
        Me.Flags.Images.SetKeyName(158, "Romania.png")
        Me.Flags.Images.SetKeyName(159, "Russian Federation.png")
        Me.Flags.Images.SetKeyName(160, "Rwanda.png")
        Me.Flags.Images.SetKeyName(161, "Saint Kitts and Nevis.png")
        Me.Flags.Images.SetKeyName(162, "Saint Lucia.png")
        Me.Flags.Images.SetKeyName(163, "Saint Pierre.png")
        Me.Flags.Images.SetKeyName(164, "Saint Vicent and the Grenadines.png")
        Me.Flags.Images.SetKeyName(165, "Samoa.png")
        Me.Flags.Images.SetKeyName(166, "San Marino.png")
        Me.Flags.Images.SetKeyName(167, "Sao Tomé and Príncipe.png")
        Me.Flags.Images.SetKeyName(168, "Saudi Arabia.png")
        Me.Flags.Images.SetKeyName(169, "Senegal.png")
        Me.Flags.Images.SetKeyName(170, "Serbia and Montenegro.png")
        Me.Flags.Images.SetKeyName(171, "Seychelles.png")
        Me.Flags.Images.SetKeyName(172, "Sierra Leone.png")
        Me.Flags.Images.SetKeyName(173, "Singapore.png")
        Me.Flags.Images.SetKeyName(174, "Slovakia.png")
        Me.Flags.Images.SetKeyName(175, "Slovenia.png")
        Me.Flags.Images.SetKeyName(176, "Soloman Islands.png")
        Me.Flags.Images.SetKeyName(177, "Somalia.png")
        Me.Flags.Images.SetKeyName(178, "South Africa.png")
        Me.Flags.Images.SetKeyName(179, "South Georgia.png")
        Me.Flags.Images.SetKeyName(180, "Republic of Korea.png")
        Me.Flags.Images.SetKeyName(181, "Soviet Union.png")
        Me.Flags.Images.SetKeyName(182, "Spain.png")
        Me.Flags.Images.SetKeyName(183, "Sri Lanka.png")
        Me.Flags.Images.SetKeyName(184, "Sudan.png")
        Me.Flags.Images.SetKeyName(185, "Suriname.png")
        Me.Flags.Images.SetKeyName(186, "Swaziland.png")
        Me.Flags.Images.SetKeyName(187, "Sweden.png")
        Me.Flags.Images.SetKeyName(188, "Switzerland.png")
        Me.Flags.Images.SetKeyName(189, "Syria.png")
        Me.Flags.Images.SetKeyName(190, "Taiwan.png")
        Me.Flags.Images.SetKeyName(191, "Tajikistan.png")
        Me.Flags.Images.SetKeyName(192, "Tanzania.png")
        Me.Flags.Images.SetKeyName(193, "Thailand.png")
        Me.Flags.Images.SetKeyName(194, "Tibet.png")
        Me.Flags.Images.SetKeyName(195, "Timor-Leste.png")
        Me.Flags.Images.SetKeyName(196, "Togo.png")
        Me.Flags.Images.SetKeyName(197, "Tonga.png")
        Me.Flags.Images.SetKeyName(198, "Trinidad and Tobago.png")
        Me.Flags.Images.SetKeyName(199, "Tunisia.png")
        Me.Flags.Images.SetKeyName(200, "Turkey.png")
        Me.Flags.Images.SetKeyName(201, "Turkmenistan.png")
        Me.Flags.Images.SetKeyName(202, "Turks and Caicos Islands.png")
        Me.Flags.Images.SetKeyName(203, "Tuvalu.png")
        Me.Flags.Images.SetKeyName(204, "UAE.png")
        Me.Flags.Images.SetKeyName(205, "Uganda.png")
        Me.Flags.Images.SetKeyName(206, "Ukraine.png")
        Me.Flags.Images.SetKeyName(207, "United Kingdom of Great Britain and Northern Ireland.png")
        Me.Flags.Images.SetKeyName(208, "United States of America.png")
        Me.Flags.Images.SetKeyName(209, "Uruguay.png")
        Me.Flags.Images.SetKeyName(210, "US Virgin Islands.png")
        Me.Flags.Images.SetKeyName(211, "Uzbekistan.png")
        Me.Flags.Images.SetKeyName(212, "Vanuatu.png")
        Me.Flags.Images.SetKeyName(213, "Vatican City.png")
        Me.Flags.Images.SetKeyName(214, "Venezuela.png")
        Me.Flags.Images.SetKeyName(215, "Vietnam.png")
        Me.Flags.Images.SetKeyName(216, "Wallis and Futuna.png")
        Me.Flags.Images.SetKeyName(217, "Yemen.png")
        Me.Flags.Images.SetKeyName(218, "Zambia.png")
        Me.Flags.Images.SetKeyName(219, "Zimbabwe.png")
        Me.Flags.Images.SetKeyName(220, "JP.png")
        Me.Flags.Images.SetKeyName(221, "Mota.png")
        Me.Flags.Images.SetKeyName(222, "Libya.png")
        Me.Flags.Images.SetKeyName(223, "South Sudan.png")
        Me.Flags.Images.SetKeyName(224, "Democratic Republic of the Congo.png")
        Me.Flags.Images.SetKeyName(225, "Iraq.png")
        Me.Flags.Images.SetKeyName(226, "Haiti.png")
        '
        'counterd
        '
        Me.counterd.AutoSize = True
        Me.counterd.Location = New System.Drawing.Point(22, 19)
        Me.counterd.Name = "counterd"
        Me.counterd.Size = New System.Drawing.Size(19, 13)
        Me.counterd.TabIndex = 7
        Me.counterd.Text = "00"
        Me.counterd.Visible = False
        '
        'SLT
        '
        Me.SLT.AutoSize = True
        Me.SLT.Location = New System.Drawing.Point(22, 46)
        Me.SLT.Name = "SLT"
        Me.SLT.Size = New System.Drawing.Size(19, 13)
        Me.SLT.TabIndex = 8
        Me.SLT.Text = "00"
        Me.SLT.Visible = False
        '
        'Committee
        '
        Me.Committee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Committee.AutoSize = True
        Me.Committee.BackColor = System.Drawing.Color.Transparent
        Me.Committee.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Committee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Committee.Location = New System.Drawing.Point(11, 14)
        Me.Committee.Name = "Committee"
        Me.Committee.Size = New System.Drawing.Size(0, 24)
        Me.Committee.TabIndex = 9
        '
        'President
        '
        Me.President.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.President.AutoSize = True
        Me.President.BackColor = System.Drawing.Color.Transparent
        Me.President.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.President.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.President.Location = New System.Drawing.Point(28, 71)
        Me.President.Name = "President"
        Me.President.Size = New System.Drawing.Size(0, 20)
        Me.President.TabIndex = 10
        '
        'Question1
        '
        Me.Question1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Question1.AutoSize = True
        Me.Question1.BackColor = System.Drawing.Color.Transparent
        Me.Question1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question1.Location = New System.Drawing.Point(63, 290)
        Me.Question1.Name = "Question1"
        Me.Question1.Size = New System.Drawing.Size(197, 36)
        Me.Question1.TabIndex = 11
        Me.Question1.Text = "Speaker's List"
        '
        'Question2
        '
        Me.Question2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Question2.AutoSize = True
        Me.Question2.BackColor = System.Drawing.Color.Transparent
        Me.Question2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question2.Location = New System.Drawing.Point(64, 326)
        Me.Question2.Name = "Question2"
        Me.Question2.Size = New System.Drawing.Size(197, 36)
        Me.Question2.TabIndex = 12
        Me.Question2.Text = "Speaker's List"
        '
        'Question3
        '
        Me.Question3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Question3.AutoSize = True
        Me.Question3.BackColor = System.Drawing.Color.Transparent
        Me.Question3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question3.Location = New System.Drawing.Point(63, 362)
        Me.Question3.Name = "Question3"
        Me.Question3.Size = New System.Drawing.Size(197, 36)
        Me.Question3.TabIndex = 13
        Me.Question3.Text = "Speaker's List"
        '
        'Question4
        '
        Me.Question4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Question4.AutoSize = True
        Me.Question4.BackColor = System.Drawing.Color.Transparent
        Me.Question4.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question4.Location = New System.Drawing.Point(64, 398)
        Me.Question4.Name = "Question4"
        Me.Question4.Size = New System.Drawing.Size(197, 36)
        Me.Question4.TabIndex = 14
        Me.Question4.Text = "Speaker's List"
        '
        'Question5
        '
        Me.Question5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Question5.AutoSize = True
        Me.Question5.BackColor = System.Drawing.Color.Transparent
        Me.Question5.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question5.Location = New System.Drawing.Point(63, 434)
        Me.Question5.Name = "Question5"
        Me.Question5.Size = New System.Drawing.Size(197, 36)
        Me.Question5.TabIndex = 15
        Me.Question5.Text = "Speaker's List"
        '
        'SO4
        '
        Me.SO4.AutoSize = True
        Me.SO4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SO4.Location = New System.Drawing.Point(32, 215)
        Me.SO4.Name = "SO4"
        Me.SO4.Size = New System.Drawing.Size(0, 39)
        Me.SO4.TabIndex = 5
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 606)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Dots)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Question5)
        Me.Controls.Add(Me.Question4)
        Me.Controls.Add(Me.Question3)
        Me.Controls.Add(Me.Question2)
        Me.Controls.Add(Me.Question1)
        Me.Controls.Add(Me.NowSpeaking)
        Me.Controls.Add(Me.President)
        Me.Controls.Add(Me.Committee)
        Me.Controls.Add(Me.NextSpeaker)
        Me.Controls.Add(Me.SLT)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.Topic)
        Me.Controls.Add(Me.counterd)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Moderating and Organizing TecMUN Application"
        Me.NowSpeaking.ResumeLayout(False)
        Me.NowSpeaking.PerformLayout()
        CType(Me.flag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NextSpeaker.ResumeLayout(False)
        Me.NextSpeaker.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Topic As System.Windows.Forms.Label
    Friend WithEvents Minutes As System.Windows.Forms.Label
    Friend WithEvents Seconds As System.Windows.Forms.Label
    Friend WithEvents Dots As System.Windows.Forms.Label
    Friend WithEvents State As System.Windows.Forms.Label
    Friend WithEvents NowSpeaking As System.Windows.Forms.GroupBox
    Friend WithEvents NextSpeaker As System.Windows.Forms.GroupBox
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents flag As System.Windows.Forms.PictureBox
    Friend WithEvents Flags As System.Windows.Forms.ImageList
    Friend WithEvents counterd As System.Windows.Forms.Label
    Friend WithEvents SLT As System.Windows.Forms.Label
    Friend WithEvents NSL As System.Windows.Forms.Label
    Friend WithEvents NS3L As System.Windows.Forms.Label
    Friend WithEvents NS2L As System.Windows.Forms.Label
    Friend WithEvents NS1L As System.Windows.Forms.Label
    Friend WithEvents Committee As System.Windows.Forms.Label
    Friend WithEvents President As System.Windows.Forms.Label
    Friend WithEvents Question1 As System.Windows.Forms.Label
    Friend WithEvents Question2 As System.Windows.Forms.Label
    Friend WithEvents Question3 As System.Windows.Forms.Label
    Friend WithEvents Question4 As System.Windows.Forms.Label
    Friend WithEvents Question5 As System.Windows.Forms.Label
    Friend WithEvents SO4 As Label
End Class
