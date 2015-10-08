using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

static class Fonts {

	public static string FontAwesomeTTF { get; set; }

	public static Font FontAwesome { get; set; }

	public static float Size {  get; set; }

	public static FontStyle Style { get; set; }

	static Fonts() {
		FontAwesomeTTF = "fontawesome-webfont.ttf";
		Style = FontStyle.Regular;
		Size = 20;
		Reload();
	}


	public static void Reload() {
		PrivateFontCollection f = new PrivateFontCollection();
		f.AddFontFile(FontAwesomeTTF);
		FontAwesome = new Font(f.Families[0], Size, Style);
	}

	public static void Reload(float newSize) {
		Size=newSize;
		Reload();
	}

	public static void Reload( FontStyle newStyle ) {
		Style=newStyle;
		Reload();
	}

	private static void Reload(float newSize, FontStyle newStyle) {
		Size=newSize;
		Style=newStyle;
		Reload();
	}

	private static string UnicodeToChar( string hex ) {
		int code=int.Parse( hex, System.Globalization.NumberStyles.HexNumber );
		string unicodeString=char.ConvertFromUtf32( code );
		return unicodeString;
	}

	public static class fa {
		/**
			 * **********************************************************************
				Font Awesome uses the Unicode Private Use Area (PUA) to ensure screen
				readers do not read off random characters that represent icons
			 * **********************************************************************

			.fa-glass:before {
			  content: "\f000";
			}
			.fa-music:before {
			  content: "\f001";
			}
			.fa-search:before {
			  content: "\f002";
			}
			.fa-envelope-o:before {
			  content: "\f003";
			}
			.fa-heart:before {
			  content: "\f004";
			}
			.fa-star:before {
			  content: "\f005";
			}
			.fa-star-o:before {
			  content: "\f006";
			}
			.fa-user:before {
			  content: "\f007";
			}
			.fa-film:before {
			  content: "\f008";
			}
			.fa-th-large:before {
			  content: "\f009";
			}
			.fa-th:before {
			  content: "\f00a";
			}
			.fa-th-list:before {
			  content: "\f00b";
			}
			.fa-check:before {
			  content: "\f00c";
			}
			.fa-remove:before,
			.fa-close:before,
			.fa-times:before {
			  content: "\f00d";
			}
			.fa-search-plus:before {
			  content: "\f00e";
			}
			.fa-search-minus:before {
			  content: "\f010";
			}
			.fa-power-off:before {
			  content: "\f011";
			}
			.fa-signal:before {
			  content: "\f012";
			}
			.fa-gear:before,
			.fa-cog:before {
			  content: "\f013";
			}
			.fa-trash-o:before {
			  content: "\f014";
			}
			.fa-home:before {
			  content: "\f015";
			}
			.fa-file-o:before {
			  content: "\f016";
			}
			.fa-clock-o:before {
			  content: "\f017";
			}
			.fa-road:before {
			  content: "\f018";
			}
			.fa-download:before {
			  content: "\f019";
			}
			.fa-arrow-circle-o-down:before {
			  content: "\f01a";
			}
			.fa-arrow-circle-o-up:before {
			  content: "\f01b";
			}
			.fa-inbox:before {
			  content: "\f01c";
			}
			.fa-play-circle-o:before {
			  content: "\f01d";
			}
			.fa-rotate-right:before,
			.fa-repeat:before {
			  content: "\f01e";
			}
			.fa-refresh:before {
			  content: "\f021";
			}
			.fa-list-alt:before {
			  content: "\f022";
			}
			.fa-lock:before {
			  content: "\f023";
			}
			.fa-flag:before {
			  content: "\f024";
			}
			.fa-headphones:before {
			  content: "\f025";
			}
			.fa-volume-off:before {
			  content: "\f026";
			}
			.fa-volume-down:before {
			  content: "\f027";
			}
			.fa-volume-up:before {
			  content: "\f028";
			}
			.fa-qrcode:before {
			  content: "\f029";
			}
			.fa-barcode:before {
			  content: "\f02a";
			}
			.fa-tag:before {
			  content: "\f02b";
			}
			.fa-tags:before {
			  content: "\f02c";
			}
			.fa-book:before {
			  content: "\f02d";
			}
			.fa-bookmark:before {
			  content: "\f02e";
			}
			.fa-print:before {
			  content: "\f02f";
			}
			.fa-camera:before {
			  content: "\f030";
			}
			.fa-font:before {
			  content: "\f031";
			}
			.fa-bold:before {
			  content: "\f032";
			}
			.fa-italic:before {
			  content: "\f033";
			}
			.fa-text-height:before {
			  content: "\f034";
			}
			.fa-text-width:before {
			  content: "\f035";
			}
			.fa-align-left:before {
			  content: "\f036";
			}
			.fa-align-center:before {
			  content: "\f037";
			}
			.fa-align-right:before {
			  content: "\f038";
			}
			.fa-align-justify:before {
			  content: "\f039";
			}
			.fa-list:before {
			  content: "\f03a";
			}
			.fa-dedent:before,
			.fa-outdent:before {
			  content: "\f03b";
			}
			.fa-indent:before {
			  content: "\f03c";
			}
			.fa-video-camera:before {
			  content: "\f03d";
			}
			.fa-photo:before,
			.fa-image:before,
			.fa-picture-o:before {
			  content: "\f03e";
			}
			.fa-pencil:before {
			  content: "\f040";
			}
			.fa-map-marker:before {
			  content: "\f041";
			}
			.fa-adjust:before {
			  content: "\f042";
			}
			.fa-tint:before {
			  content: "\f043";
			}
			.fa-edit:before,
			.fa-pencil-square-o:before {
			  content: "\f044";
			}
			.fa-share-square-o:before {
			  content: "\f045";
			}
			.fa-check-square-o:before {
			  content: "\f046";
			}
			.fa-arrows:before {
			  content: "\f047";
			}
			.fa-step-backward:before {
			  content: "\f048";
			}
			.fa-fast-backward:before {
			  content: "\f049";
			}
			.fa-backward:before {
			  content: "\f04a";
			}
			.fa-play:before {
			  content: "\f04b";
			}
			.fa-pause:before {
			  content: "\f04c";
			}
			.fa-stop:before {
			  content: "\f04d";
			}
			.fa-forward:before {
			  content: "\f04e";
			}
			.fa-fast-forward:before {
			  content: "\f050";
			}
			.fa-step-forward:before {
			  content: "\f051";
			}
			.fa-eject:before {
			  content: "\f052";
			}
			.fa-chevron-left:before {
			  content: "\f053";
			}
			.fa-chevron-right:before {
			  content: "\f054";
			}
			.fa-plus-circle:before {
			  content: "\f055";
			}
			.fa-minus-circle:before {
			  content: "\f056";
			}
			.fa-times-circle:before {
			  content: "\f057";
			}
			.fa-check-circle:before {
			  content: "\f058";
			}
			.fa-question-circle:before {
			  content: "\f059";
			}
			.fa-info-circle:before {
			  content: "\f05a";
			}
			.fa-crosshairs:before {
			  content: "\f05b";
			}
			.fa-times-circle-o:before {
			  content: "\f05c";
			}
			.fa-check-circle-o:before {
			  content: "\f05d";
			}
			.fa-ban:before {
			  content: "\f05e";
			}
			.fa-arrow-left:before {
			  content: "\f060";
			}
			.fa-arrow-right:before {
			  content: "\f061";
			}
			.fa-arrow-up:before {
			  content: "\f062";
			}
			.fa-arrow-down:before {
			  content: "\f063";
			}
			.fa-mail-forward:before,
			.fa-share:before {
			  content: "\f064";
			}
			.fa-expand:before {
			  content: "\f065";
			}
			.fa-compress:before {
			  content: "\f066";
			}
			.fa-plus:before {
			  content: "\f067";
			}
			.fa-minus:before {
			  content: "\f068";
			}
			.fa-asterisk:before {
			  content: "\f069";
			}
			.fa-exclamation-circle:before {
			  content: "\f06a";
			}
			.fa-gift:before {
			  content: "\f06b";
			}
			.fa-leaf:before {
			  content: "\f06c";
			}
			.fa-fire:before {
			  content: "\f06d";
			}
			.fa-eye:before {
			  content: "\f06e";
			}
			.fa-eye-slash:before {
			  content: "\f070";
			}
			.fa-warning:before,
			.fa-exclamation-triangle:before {
			  content: "\f071";
			}
			.fa-plane:before {
			  content: "\f072";
			}
			.fa-calendar:before {
			  content: "\f073";
			}
			.fa-random:before {
			  content: "\f074";
			}
			.fa-comment:before {
			  content: "\f075";
			}
			.fa-magnet:before {
			  content: "\f076";
			}
			.fa-chevron-up:before {
			  content: "\f077";
			}
			.fa-chevron-down:before {
			  content: "\f078";
			}
			.fa-retweet:before {
			  content: "\f079";
			}
			.fa-shopping-cart:before {
			  content: "\f07a";
			}
			.fa-folder:before {
			  content: "\f07b";
			}
			.fa-folder-open:before {
			  content: "\f07c";
			}
			.fa-arrows-v:before {
			  content: "\f07d";
			}
			.fa-arrows-h:before {
			  content: "\f07e";
			}
			.fa-bar-chart-o:before,
			.fa-bar-chart:before {
			  content: "\f080";
			}
			.fa-twitter-square:before {
			  content: "\f081";
			}
			.fa-facebook-square:before {
			  content: "\f082";
			}
			.fa-camera-retro:before {
			  content: "\f083";
			}
			.fa-key:before {
			  content: "\f084";
			}
			.fa-gears:before,
			.fa-cogs:before {
			  content: "\f085";
			}
			.fa-comments:before {
			  content: "\f086";
			}
			.fa-thumbs-o-up:before {
			  content: "\f087";
			}
			.fa-thumbs-o-down:before {
			  content: "\f088";
			}
			.fa-star-half:before {
			  content: "\f089";
			}
			.fa-heart-o:before {
			  content: "\f08a";
			}
			.fa-sign-out:before {
			  content: "\f08b";
			}
			.fa-linkedin-square:before {
			  content: "\f08c";
			}
			.fa-thumb-tack:before {
			  content: "\f08d";
			}
			.fa-external-link:before {
			  content: "\f08e";
			}
			.fa-sign-in:before {
			  content: "\f090";
			}
			.fa-trophy:before {
			  content: "\f091";
			}
			.fa-github-square:before {
			  content: "\f092";
			}
			.fa-upload:before {
			  content: "\f093";
			}
			.fa-lemon-o:before {
			  content: "\f094";
			}
			.fa-phone:before {
			  content: "\f095";
			}
			.fa-square-o:before {
			  content: "\f096";
			}
			.fa-bookmark-o:before {
			  content: "\f097";
			}
			.fa-phone-square:before {
			  content: "\f098";
			}
			.fa-twitter:before {
			  content: "\f099";
			}
			.fa-facebook-f:before,
			.fa-facebook:before {
			  content: "\f09a";
			}
			.fa-github:before {
			  content: "\f09b";
			}
			.fa-unlock:before {
			  content: "\f09c";
			}
			.fa-credit-card:before {
			  content: "\f09d";
			}
			.fa-feed:before,
			.fa-rss:before {
			  content: "\f09e";
			}
			.fa-hdd-o:before {
			  content: "\f0a0";
			}
			.fa-bullhorn:before {
			  content: "\f0a1";
			}
			.fa-bell:before {
			  content: "\f0f3";
			}
			.fa-certificate:before {
			  content: "\f0a3";
			}
			.fa-hand-o-right:before {
			  content: "\f0a4";
			}
			.fa-hand-o-left:before {
			  content: "\f0a5";
			}
			.fa-hand-o-up:before {
			  content: "\f0a6";
			}
			.fa-hand-o-down:before {
			  content: "\f0a7";
			}
			.fa-arrow-circle-left:before {
			  content: "\f0a8";
			}
			.fa-arrow-circle-right:before {
			  content: "\f0a9";
			}
			.fa-arrow-circle-up:before {
			  content: "\f0aa";
			}
			.fa-arrow-circle-down:before {
			  content: "\f0ab";
			}
			.fa-globe:before {
			  content: "\f0ac";
			}
			.fa-wrench:before {
			  content: "\f0ad";
			}
			.fa-tasks:before {
			  content: "\f0ae";
			}
			.fa-filter:before {
			  content: "\f0b0";
			}
			.fa-briefcase:before {
			  content: "\f0b1";
			}
			.fa-arrows-alt:before {
			  content: "\f0b2";
			}
			.fa-group:before,
			.fa-users:before {
			  content: "\f0c0";
			}
			.fa-chain:before,
			.fa-link:before {
			  content: "\f0c1";
			}
			.fa-cloud:before {
			  content: "\f0c2";
			}
			.fa-flask:before {
			  content: "\f0c3";
			}
			.fa-cut:before,
			.fa-scissors:before {
			  content: "\f0c4";
			}
			.fa-copy:before,
			.fa-files-o:before {
			  content: "\f0c5";
			}
			.fa-paperclip:before {
			  content: "\f0c6";
			}
			.fa-save:before,
			.fa-floppy-o:before {
			  content: "\f0c7";
			}
			.fa-square:before {
			  content: "\f0c8";
			}
			.fa-navicon:before,
			.fa-reorder:before,
			.fa-bars:before {
			  content: "\f0c9";
			}
			.fa-list-ul:before {
			  content: "\f0ca";
			}
			.fa-list-ol:before {
			  content: "\f0cb";
			}
			.fa-strikethrough:before {
			  content: "\f0cc";
			}
			.fa-underline:before {
			  content: "\f0cd";
			}
			.fa-table:before {
			  content: "\f0ce";
			}
			.fa-magic:before {
			  content: "\f0d0";
			}
			.fa-truck:before {
			  content: "\f0d1";
			}
			.fa-pinterest:before {
			  content: "\f0d2";
			}
			.fa-pinterest-square:before {
			  content: "\f0d3";
			}
			.fa-google-plus-square:before {
			  content: "\f0d4";
			}
			.fa-google-plus:before {
			  content: "\f0d5";
			}
			.fa-money:before {
			  content: "\f0d6";
			}
			.fa-caret-down:before {
			  content: "\f0d7";
			}
			.fa-caret-up:before {
			  content: "\f0d8";
			}
			.fa-caret-left:before {
			  content: "\f0d9";
			}
			.fa-caret-right:before {
			  content: "\f0da";
			}
			.fa-columns:before {
			  content: "\f0db";
			}
			.fa-unsorted:before,
			.fa-sort:before {
			  content: "\f0dc";
			}
			.fa-sort-down:before,
			.fa-sort-desc:before {
			  content: "\f0dd";
			}
			.fa-sort-up:before,
			.fa-sort-asc:before {
			  content: "\f0de";
			}
			.fa-envelope:before {
			  content: "\f0e0";
			}
			.fa-linkedin:before {
			  content: "\f0e1";
			}
			.fa-rotate-left:before,
			.fa-undo:before {
			  content: "\f0e2";
			}
			.fa-legal:before,
			.fa-gavel:before {
			  content: "\f0e3";
			}
			.fa-dashboard:before,
			.fa-tachometer:before {
			  content: "\f0e4";
			}
			.fa-comment-o:before {
			  content: "\f0e5";
			}
			.fa-comments-o:before {
			  content: "\f0e6";
			}
			.fa-flash:before,
			.fa-bolt:before {
			  content: "\f0e7";
			}
			.fa-sitemap:before {
			  content: "\f0e8";
			}
			.fa-umbrella:before {
			  content: "\f0e9";
			}
			.fa-paste:before,
			.fa-clipboard:before {
			  content: "\f0ea";
			}
			.fa-lightbulb-o:before {
			  content: "\f0eb";
			}
			.fa-exchange:before {
			  content: "\f0ec";
			}
			.fa-cloud-download:before {
			  content: "\f0ed";
			}
			.fa-cloud-upload:before {
			  content: "\f0ee";
			}
			.fa-user-md:before {
			  content: "\f0f0";
			}
			.fa-stethoscope:before {
			  content: "\f0f1";
			}
			.fa-suitcase:before {
			  content: "\f0f2";
			}
			.fa-bell-o:before {
			  content: "\f0a2";
			}
			.fa-coffee:before {
			  content: "\f0f4";
			}
			.fa-cutlery:before {
			  content: "\f0f5";
			}
			.fa-file-text-o:before {
			  content: "\f0f6";
			}
			.fa-building-o:before {
			  content: "\f0f7";
			}
			.fa-hospital-o:before {
			  content: "\f0f8";
			}
			.fa-ambulance:before {
			  content: "\f0f9";
			}
			.fa-medkit:before {
			  content: "\f0fa";
			}
			.fa-fighter-jet:before {
			  content: "\f0fb";
			}
			.fa-beer:before {
			  content: "\f0fc";
			}
			.fa-h-square:before {
			  content: "\f0fd";
			}
			.fa-plus-square:before {
			  content: "\f0fe";
			}
			.fa-angle-double-left:before {
			  content: "\f100";
			}
			.fa-angle-double-right:before {
			  content: "\f101";
			}
			.fa-angle-double-up:before {
			  content: "\f102";
			}
			.fa-angle-double-down:before {
			  content: "\f103";
			}
			.fa-angle-left:before {
			  content: "\f104";
			}
			.fa-angle-right:before {
			  content: "\f105";
			}
			.fa-angle-up:before {
			  content: "\f106";
			}
			.fa-angle-down:before {
			  content: "\f107";
			}
			.fa-desktop:before {
			  content: "\f108";
			}
			.fa-laptop:before {
			  content: "\f109";
			}
			.fa-tablet:before {
			  content: "\f10a";
			}
			.fa-mobile-phone:before,
			.fa-mobile:before {
			  content: "\f10b";
			}
			.fa-circle-o:before {
			  content: "\f10c";
			}
			.fa-quote-left:before {
			  content: "\f10d";
			}
			.fa-quote-right:before {
			  content: "\f10e";
			}
			.fa-spinner:before {
			  content: "\f110";
			}
			.fa-circle:before {
			  content: "\f111";
			}
			.fa-mail-reply:before,
			.fa-reply:before {
			  content: "\f112";
			}
			.fa-github-alt:before {
			  content: "\f113";
			}
			.fa-folder-o:before {
			  content: "\f114";
			}
			.fa-folder-open-o:before {
			  content: "\f115";
			}
			.fa-smile-o:before {
			  content: "\f118";
			}
			.fa-frown-o:before {
			  content: "\f119";
			}
			.fa-meh-o:before {
			  content: "\f11a";
			}
			.fa-gamepad:before {
			  content: "\f11b";
			}
			.fa-keyboard-o:before {
			  content: "\f11c";
			}
			.fa-flag-o:before {
			  content: "\f11d";
			}
			.fa-flag-checkered:before {
			  content: "\f11e";
			}
			.fa-terminal:before {
			  content: "\f120";
			}
			.fa-code:before {
			  content: "\f121";
			}
			.fa-mail-reply-all:before,
			.fa-reply-all:before {
			  content: "\f122";
			}
			.fa-star-half-empty:before,
			.fa-star-half-full:before,
			.fa-star-half-o:before {
			  content: "\f123";
			}
			.fa-location-arrow:before {
			  content: "\f124";
			}
			.fa-crop:before {
			  content: "\f125";
			}
			.fa-code-fork:before {
			  content: "\f126";
			}
			.fa-unlink:before,
			.fa-chain-broken:before {
			  content: "\f127";
			}
			.fa-question:before {
			  content: "\f128";
			}
			.fa-info:before {
			  content: "\f129";
			}
			.fa-exclamation:before {
			  content: "\f12a";
			}
			.fa-superscript:before {
			  content: "\f12b";
			}
			.fa-subscript:before {
			  content: "\f12c";
			}
			.fa-eraser:before {
			  content: "\f12d";
			}
			.fa-puzzle-piece:before {
			  content: "\f12e";
			}
			.fa-microphone:before {
			  content: "\f130";
			}
			.fa-microphone-slash:before {
			  content: "\f131";
			}
			.fa-shield:before {
			  content: "\f132";
			}
			.fa-calendar-o:before {
			  content: "\f133";
			}
			.fa-fire-extinguisher:before {
			  content: "\f134";
			}
			.fa-rocket:before {
			  content: "\f135";
			}
			.fa-maxcdn:before {
			  content: "\f136";
			}
			.fa-chevron-circle-left:before {
			  content: "\f137";
			}
			.fa-chevron-circle-right:before {
			  content: "\f138";
			}
			.fa-chevron-circle-up:before {
			  content: "\f139";
			}
			.fa-chevron-circle-down:before {
			  content: "\f13a";
			}
			.fa-html5:before {
			  content: "\f13b";
			}
			.fa-css3:before {
			  content: "\f13c";
			}
			.fa-anchor:before {
			  content: "\f13d";
			}
			.fa-unlock-alt:before {
			  content: "\f13e";
			}
			.fa-bullseye:before {
			  content: "\f140";
			}
			.fa-ellipsis-h:before {
			  content: "\f141";
			}
			.fa-ellipsis-v:before {
			  content: "\f142";
			}
			.fa-rss-square:before {
			  content: "\f143";
			}
			.fa-play-circle:before {
			  content: "\f144";
			}
			.fa-ticket:before {
			  content: "\f145";
			}
			.fa-minus-square:before {
			  content: "\f146";
			}
			.fa-minus-square-o:before {
			  content: "\f147";
			}
			.fa-level-up:before {
			  content: "\f148";
			}
			.fa-level-down:before {
			  content: "\f149";
			}
			.fa-check-square:before {
			  content: "\f14a";
			}
			.fa-pencil-square:before {
			  content: "\f14b";
			}
			.fa-external-link-square:before {
			  content: "\f14c";
			}
			.fa-share-square:before {
			  content: "\f14d";
			}
			.fa-compass:before {
			  content: "\f14e";
			}
			.fa-toggle-down:before,
			.fa-caret-square-o-down:before {
			  content: "\f150";
			}
			.fa-toggle-up:before,
			.fa-caret-square-o-up:before {
			  content: "\f151";
			}
			.fa-toggle-right:before,
			.fa-caret-square-o-right:before {
			  content: "\f152";
			}
			.fa-euro:before,
			.fa-eur:before {
			  content: "\f153";
			}
			.fa-gbp:before {
			  content: "\f154";
			}
			.fa-dollar:before,
			.fa-usd:before {
			  content: "\f155";
			}
			.fa-rupee:before,
			.fa-inr:before {
			  content: "\f156";
			}
			.fa-cny:before,
			.fa-rmb:before,
			.fa-yen:before,
			.fa-jpy:before {
			  content: "\f157";
			}
			.fa-ruble:before,
			.fa-rouble:before,
			.fa-rub:before {
			  content: "\f158";
			}
			.fa-won:before,
			.fa-krw:before {
			  content: "\f159";
			}
			.fa-bitcoin:before,
			.fa-btc:before {
			  content: "\f15a";
			}
			.fa-file:before {
			  content: "\f15b";
			}
			.fa-file-text:before {
			  content: "\f15c";
			}
			.fa-sort-alpha-asc:before {
			  content: "\f15d";
			}
			.fa-sort-alpha-desc:before {
			  content: "\f15e";
			}
			.fa-sort-amount-asc:before {
			  content: "\f160";
			}
			.fa-sort-amount-desc:before {
			  content: "\f161";
			}
			.fa-sort-numeric-asc:before {
			  content: "\f162";
			}
			.fa-sort-numeric-desc:before {
			  content: "\f163";
			}
			.fa-thumbs-up:before {
			  content: "\f164";
			}
			.fa-thumbs-down:before {
			  content: "\f165";
			}
			.fa-youtube-square:before {
			  content: "\f166";
			}
			.fa-youtube:before {
			  content: "\f167";
			}
			.fa-xing:before {
			  content: "\f168";
			}
			.fa-xing-square:before {
			  content: "\f169";
			}
			.fa-youtube-play:before {
			  content: "\f16a";
			}
			.fa-dropbox:before {
			  content: "\f16b";
			}
			.fa-stack-overflow:before {
			  content: "\f16c";
			}
			.fa-instagram:before {
			  content: "\f16d";
			}
			.fa-flickr:before {
			  content: "\f16e";
			}
			.fa-adn:before {
			  content: "\f170";
			}
			.fa-bitbucket:before {
			  content: "\f171";
			}
			.fa-bitbucket-square:before {
			  content: "\f172";
			}
			.fa-tumblr:before {
			  content: "\f173";
			}
			.fa-tumblr-square:before {
			  content: "\f174";
			}
			.fa-long-arrow-down:before {
			  content: "\f175";
			}
			.fa-long-arrow-up:before {
			  content: "\f176";
			}
			.fa-long-arrow-left:before {
			  content: "\f177";
			}
			.fa-long-arrow-right:before {
			  content: "\f178";
			}
			.fa-apple:before {
			  content: "\f179";
			}
			.fa-windows:before {
			  content: "\f17a";
			}
			.fa-android:before {
			  content: "\f17b";
			}
			.fa-linux:before {
			  content: "\f17c";
			}
			.fa-dribbble:before {
			  content: "\f17d";
			}
			.fa-skype:before {
			  content: "\f17e";
			}
			.fa-foursquare:before {
			  content: "\f180";
			}
			.fa-trello:before {
			  content: "\f181";
			}
			.fa-female:before {
			  content: "\f182";
			}
			.fa-male:before {
			  content: "\f183";
			}
			.fa-gittip:before,
			.fa-gratipay:before {
			  content: "\f184";
			}
			.fa-sun-o:before {
			  content: "\f185";
			}
			.fa-moon-o:before {
			  content: "\f186";
			}
			.fa-archive:before {
			  content: "\f187";
			}
			.fa-bug:before {
			  content: "\f188";
			}
			.fa-vk:before {
			  content: "\f189";
			}
			.fa-weibo:before {
			  content: "\f18a";
			}
			.fa-renren:before {
			  content: "\f18b";
			}
			.fa-pagelines:before {
			  content: "\f18c";
			}
			.fa-stack-exchange:before {
			  content: "\f18d";
			}
			.fa-arrow-circle-o-right:before {
			  content: "\f18e";
			}
			.fa-arrow-circle-o-left:before {
			  content: "\f190";
			}
			.fa-toggle-left:before,
			.fa-caret-square-o-left:before {
			  content: "\f191";
			}
			.fa-dot-circle-o:before {
			  content: "\f192";
			}
			.fa-wheelchair:before {
			  content: "\f193";
			}
			.fa-vimeo-square:before {
			  content: "\f194";
			}
			.fa-turkish-lira:before,
			.fa-try:before {
			  content: "\f195";
			}
			.fa-plus-square-o:before {
			  content: "\f196";
			}
			.fa-space-shuttle:before {
			  content: "\f197";
			}
			.fa-slack:before {
			  content: "\f198";
			}
			.fa-envelope-square:before {
			  content: "\f199";
			}
			.fa-wordpress:before {
			  content: "\f19a";
			}
			.fa-openid:before {
			  content: "\f19b";
			}
			.fa-institution:before,
			.fa-bank:before,
			.fa-university:before {
			  content: "\f19c";
			}
			.fa-mortar-board:before,
			.fa-graduation-cap:before {
			  content: "\f19d";
			}
			.fa-yahoo:before {
			  content: "\f19e";
			}
			.fa-google:before {
			  content: "\f1a0";
			}
			.fa-reddit:before {
			  content: "\f1a1";
			}
			.fa-reddit-square:before {
			  content: "\f1a2";
			}
			.fa-stumbleupon-circle:before {
			  content: "\f1a3";
			}
			.fa-stumbleupon:before {
			  content: "\f1a4";
			}
			.fa-delicious:before {
			  content: "\f1a5";
			}
			.fa-digg:before {
			  content: "\f1a6";
			}
			.fa-pied-piper:before {
			  content: "\f1a7";
			}
			.fa-pied-piper-alt:before {
			  content: "\f1a8";
			}
			.fa-drupal:before {
			  content: "\f1a9";
			}
			.fa-joomla:before {
			  content: "\f1aa";
			}
			.fa-language:before {
			  content: "\f1ab";
			}
			.fa-fax:before {
			  content: "\f1ac";
			}
			.fa-building:before {
			  content: "\f1ad";
			}
			.fa-child:before {
			  content: "\f1ae";
			}
			.fa-paw:before {
			  content: "\f1b0";
			}
			.fa-spoon:before {
			  content: "\f1b1";
			}
			.fa-cube:before {
			  content: "\f1b2";
			}
			.fa-cubes:before {
			  content: "\f1b3";
			}
			.fa-behance:before {
			  content: "\f1b4";
			}
			.fa-behance-square:before {
			  content: "\f1b5";
			}
			.fa-steam:before {
			  content: "\f1b6";
			}
			.fa-steam-square:before {
			  content: "\f1b7";
			}
			.fa-recycle:before {
			  content: "\f1b8";
			}
			.fa-automobile:before,
			.fa-car:before {
			  content: "\f1b9";
			}
			.fa-cab:before,
			.fa-taxi:before {
			  content: "\f1ba";
			}
			.fa-tree:before {
			  content: "\f1bb";
			}
			.fa-spotify:before {
			  content: "\f1bc";
			}
			.fa-deviantart:before {
			  content: "\f1bd";
			}
			.fa-soundcloud:before {
			  content: "\f1be";
			}
			.fa-database:before {
			  content: "\f1c0";
			}
			.fa-file-pdf-o:before {
			  content: "\f1c1";
			}
			.fa-file-word-o:before {
			  content: "\f1c2";
			}
			.fa-file-excel-o:before {
			  content: "\f1c3";
			}
			.fa-file-powerpoint-o:before {
			  content: "\f1c4";
			}
			.fa-file-photo-o:before,
			.fa-file-picture-o:before,
			.fa-file-image-o:before {
			  content: "\f1c5";
			}
			.fa-file-zip-o:before,
			.fa-file-archive-o:before {
			  content: "\f1c6";
			}
			.fa-file-sound-o:before,
			.fa-file-audio-o:before {
			  content: "\f1c7";
			}
			.fa-file-movie-o:before,
			.fa-file-video-o:before {
			  content: "\f1c8";
			}
			.fa-file-code-o:before {
			  content: "\f1c9";
			}
			.fa-vine:before {
			  content: "\f1ca";
			}
			.fa-codepen:before {
			  content: "\f1cb";
			}
			.fa-jsfiddle:before {
			  content: "\f1cc";
			}
			.fa-life-bouy:before,
			.fa-life-buoy:before,
			.fa-life-saver:before,
			.fa-support:before,
			.fa-life-ring:before {
			  content: "\f1cd";
			}
			.fa-circle-o-notch:before {
			  content: "\f1ce";
			}
			.fa-ra:before,
			.fa-rebel:before {
			  content: "\f1d0";
			}
			.fa-ge:before,
			.fa-empire:before {
			  content: "\f1d1";
			}
			.fa-git-square:before {
			  content: "\f1d2";
			}
			.fa-git:before {
			  content: "\f1d3";
			}
			.fa-y-combinator-square:before,
			.fa-yc-square:before,
			.fa-hacker-news:before {
			  content: "\f1d4";
			}
			.fa-tencent-weibo:before {
			  content: "\f1d5";
			}
			.fa-qq:before {
			  content: "\f1d6";
			}
			.fa-wechat:before,
			.fa-weixin:before {
			  content: "\f1d7";
			}
			.fa-send:before,
			.fa-paper-plane:before {
			  content: "\f1d8";
			}
			.fa-send-o:before,
			.fa-paper-plane-o:before {
			  content: "\f1d9";
			}
			.fa-history:before {
			  content: "\f1da";
			}
			.fa-circle-thin:before {
			  content: "\f1db";
			}
			.fa-header:before {
			  content: "\f1dc";
			}
			.fa-paragraph:before {
			  content: "\f1dd";
			}
			.fa-sliders:before {
			  content: "\f1de";
			}
			.fa-share-alt:before {
			  content: "\f1e0";
			}
			.fa-share-alt-square:before {
			  content: "\f1e1";
			}
			.fa-bomb:before {
			  content: "\f1e2";
			}
			.fa-soccer-ball-o:before,
			.fa-futbol-o:before {
			  content: "\f1e3";
			}
			.fa-tty:before {
			  content: "\f1e4";
			}
			.fa-binoculars:before {
			  content: "\f1e5";
			}
			.fa-plug:before {
			  content: "\f1e6";
			}
			.fa-slideshare:before {
			  content: "\f1e7";
			}
			.fa-twitch:before {
			  content: "\f1e8";
			}
			.fa-yelp:before {
			  content: "\f1e9";
			}
			.fa-newspaper-o:before {
			  content: "\f1ea";
			}
			.fa-wifi:before {
			  content: "\f1eb";
			}
			.fa-calculator:before {
			  content: "\f1ec";
			}
			.fa-paypal:before {
			  content: "\f1ed";
			}
			.fa-google-wallet:before {
			  content: "\f1ee";
			}
			.fa-cc-visa:before {
			  content: "\f1f0";
			}
			.fa-cc-mastercard:before {
			  content: "\f1f1";
			}
			.fa-cc-discover:before {
			  content: "\f1f2";
			}
			.fa-cc-amex:before {
			  content: "\f1f3";
			}
			.fa-cc-paypal:before {
			  content: "\f1f4";
			}
			.fa-cc-stripe:before {
			  content: "\f1f5";
			}
			.fa-bell-slash:before {
			  content: "\f1f6";
			}
			.fa-bell-slash-o:before {
			  content: "\f1f7";
			}
			.fa-trash:before {
			  content: "\f1f8";
			}
			.fa-copyright:before {
			  content: "\f1f9";
			}
			.fa-at:before {
			  content: "\f1fa";
			}
			.fa-eyedropper:before {
			  content: "\f1fb";
			}
			.fa-paint-brush:before {
			  content: "\f1fc";
			}
			.fa-birthday-cake:before {
			  content: "\f1fd";
			}
			.fa-area-chart:before {
			  content: "\f1fe";
			}
			.fa-pie-chart:before {
			  content: "\f200";
			}
			.fa-line-chart:before {
			  content: "\f201";
			}
			.fa-lastfm:before {
			  content: "\f202";
			}
			.fa-lastfm-square:before {
			  content: "\f203";
			}
			.fa-toggle-off:before {
			  content: "\f204";
			}
			.fa-toggle-on:before {
			  content: "\f205";
			}
			.fa-bicycle:before {
			  content: "\f206";
			}
			.fa-bus:before {
			  content: "\f207";
			}
			.fa-ioxhost:before {
			  content: "\f208";
			}
			.fa-angellist:before {
			  content: "\f209";
			}
			.fa-cc:before {
			  content: "\f20a";
			}
			.fa-shekel:before,
			.fa-sheqel:before,
			.fa-ils:before {
			  content: "\f20b";
			}
			.fa-meanpath:before {
			  content: "\f20c";
			}
			.fa-buysellads:before {
			  content: "\f20d";
			}
			.fa-connectdevelop:before {
			  content: "\f20e";
			}
			.fa-dashcube:before {
			  content: "\f210";
			}
			.fa-forumbee:before {
			  content: "\f211";
			}
			.fa-leanpub:before {
			  content: "\f212";
			}
			.fa-sellsy:before {
			  content: "\f213";
			}
			.fa-shirtsinbulk:before {
			  content: "\f214";
			}
			.fa-simplybuilt:before {
			  content: "\f215";
			}
			.fa-skyatlas:before {
			  content: "\f216";
			}
			.fa-cart-plus:before {
			  content: "\f217";
			}
			.fa-cart-arrow-down:before {
			  content: "\f218";
			}
			.fa-diamond:before {
			  content: "\f219";
			}
			.fa-ship:before {
			  content: "\f21a";
			}
			.fa-user-secret:before {
			  content: "\f21b";
			}
			.fa-motorcycle:before {
			  content: "\f21c";
			}
			.fa-street-view:before {
			  content: "\f21d";
			}
			.fa-heartbeat:before {
			  content: "\f21e";
			}
			.fa-venus:before {
			  content: "\f221";
			}
			.fa-mars:before {
			  content: "\f222";
			}
			.fa-mercury:before {
			  content: "\f223";
			}
			.fa-intersex:before,
			.fa-transgender:before {
			  content: "\f224";
			}
			.fa-transgender-alt:before {
			  content: "\f225";
			}
			.fa-venus-double:before {
			  content: "\f226";
			}
			.fa-mars-double:before {
			  content: "\f227";
			}
			.fa-venus-mars:before {
			  content: "\f228";
			}
			.fa-mars-stroke:before {
			  content: "\f229";
			}
			.fa-mars-stroke-v:before {
			  content: "\f22a";
			}
			.fa-mars-stroke-h:before {
			  content: "\f22b";
			}
			.fa-neuter:before {
			  content: "\f22c";
			}
			.fa-genderless:before {
			  content: "\f22d";
			}
			.fa-facebook-official:before {
			  content: "\f230";
			}
			.fa-pinterest-p:before {
			  content: "\f231";
			}
			.fa-whatsapp:before {
			  content: "\f232";
			}
			.fa-server:before {
			  content: "\f233";
			}
			.fa-user-plus:before {
			  content: "\f234";
			}
			.fa-user-times:before {
			  content: "\f235";
			}
			.fa-hotel:before,
			.fa-bed:before {
			  content: "\f236";
			}
			.fa-viacoin:before {
			  content: "\f237";
			}
			.fa-train:before {
			  content: "\f238";
			}
			.fa-subway:before {
			  content: "\f239";
			}
			.fa-medium:before {
			  content: "\f23a";
			}
			.fa-yc:before,
			.fa-y-combinator:before {
			  content: "\f23b";
			}
			.fa-optin-monster:before {
			  content: "\f23c";
			}
			.fa-opencart:before {
			  content: "\f23d";
			}
			.fa-expeditedssl:before {
			  content: "\f23e";
			}
			.fa-battery-4:before,
			.fa-battery-full:before {
			  content: "\f240";
			}
			.fa-battery-3:before,
			.fa-battery-three-quarters:before {
			  content: "\f241";
			}
			.fa-battery-2:before,
			.fa-battery-half:before {
			  content: "\f242";
			}
			.fa-battery-1:before,
			.fa-battery-quarter:before {
			  content: "\f243";
			}
			.fa-battery-0:before,
			.fa-battery-empty:before {
			  content: "\f244";
			}
			.fa-mouse-pointer:before {
			  content: "\f245";
			}
			.fa-i-cursor:before {
			  content: "\f246";
			}
			.fa-object-group:before {
			  content: "\f247";
			}
			.fa-object-ungroup:before {
			  content: "\f248";
			}
			.fa-sticky-note:before {
			  content: "\f249";
			}
			.fa-sticky-note-o:before {
			  content: "\f24a";
			}
			.fa-cc-jcb:before {
			  content: "\f24b";
			}
			.fa-cc-diners-club:before {
			  content: "\f24c";
			}
			.fa-clone:before {
			  content: "\f24d";
			}
			.fa-balance-scale:before {
			  content: "\f24e";
			}
			.fa-hourglass-o:before {
			  content: "\f250";
			}
			.fa-hourglass-1:before,
			.fa-hourglass-start:before {
			  content: "\f251";
			}
			.fa-hourglass-2:before,
			.fa-hourglass-half:before {
			  content: "\f252";
			}
			.fa-hourglass-3:before,
			.fa-hourglass-end:before {
			  content: "\f253";
			}
			.fa-hourglass:before {
			  content: "\f254";
			}
			.fa-hand-grab-o:before,
			.fa-hand-rock-o:before {
			  content: "\f255";
			}
			.fa-hand-stop-o:before,
			.fa-hand-paper-o:before {
			  content: "\f256";
			}
			.fa-hand-scissors-o:before {
			  content: "\f257";
			}
			.fa-hand-lizard-o:before {
			  content: "\f258";
			}
			.fa-hand-spock-o:before {
			  content: "\f259";
			}
			.fa-hand-pointer-o:before {
			  content: "\f25a";
			}
			.fa-hand-peace-o:before {
			  content: "\f25b";
			}
			.fa-trademark:before {
			  content: "\f25c";
			}
			.fa-registered:before {
			  content: "\f25d";
			}
			.fa-creative-commons:before {
			  content: "\f25e";
			}
			.fa-gg:before {
			  content: "\f260";
			}
			.fa-gg-circle:before {
			  content: "\f261";
			}
			.fa-tripadvisor:before {
			  content: "\f262";
			}
			.fa-odnoklassniki:before {
			  content: "\f263";
			}
			.fa-odnoklassniki-square:before {
			  content: "\f264";
			}
			.fa-get-pocket:before {
			  content: "\f265";
			}
			.fa-wikipedia-w:before {
			  content: "\f266";
			}
			.fa-safari:before {
			  content: "\f267";
			}
			.fa-chrome:before {
			  content: "\f268";
			}
			.fa-firefox:before {
			  content: "\f269";
			}
			.fa-opera:before {
			  content: "\f26a";
			}
			.fa-internet-explorer:before {
			  content: "\f26b";
			}
			.fa-tv:before,
			.fa-television:before {
			  content: "\f26c";
			}
			.fa-contao:before {
			  content: "\f26d";
			}
			.fa-500px:before {
			  content: "\f26e";
			}
			.fa-amazon:before {
			  content: "\f270";
			}
			.fa-calendar-plus-o:before {
			  content: "\f271";
			}
			.fa-calendar-minus-o:before {
			  content: "\f272";
			}
			.fa-calendar-times-o:before {
			  content: "\f273";
			}
			.fa-calendar-check-o:before {
			  content: "\f274";
			}
			.fa-industry:before {
			  content: "\f275";
			}
			.fa-map-pin:before {
			  content: "\f276";
			}
			.fa-map-signs:before {
			  content: "\f277";
			}
			.fa-map-o:before {
			  content: "\f278";
			}
			.fa-map:before {
			  content: "\f279";
			}
			.fa-commenting:before {
			  content: "\f27a";
			}
			.fa-commenting-o:before {
			  content: "\f27b";
			}
			.fa-houzz:before {
			  content: "\f27c";
			}
			.fa-vimeo:before {
			  content: "\f27d";
			}
			.fa-black-tie:before {
			  content: "\f27e";
			}
			.fa-fonticons:before {
			  content: "\f280";
			}
		*/


		public static string glass { get { return UnicodeToChar("f000"); } }
		public static string music { get { return UnicodeToChar("f001"); } }
		public static string search { get { return UnicodeToChar("f002"); } }
		public static string envelope_o { get { return UnicodeToChar("f003"); } }
		public static string heart { get { return UnicodeToChar("f004"); } }
		public static string star { get { return UnicodeToChar("f005"); } }
		public static string star_o { get { return UnicodeToChar("f006"); } }
		public static string user { get { return UnicodeToChar("f007"); } }
		public static string film { get { return UnicodeToChar("f008"); } }
		public static string th_large { get { return UnicodeToChar("f009"); } }
		public static string th { get { return UnicodeToChar("f00a"); } }
		public static string th_list { get { return UnicodeToChar("f00b"); } }
		public static string check { get { return UnicodeToChar("f00c"); } }
		public static string remove { get { return UnicodeToChar("f00d"); } }
		public static string close { get { return UnicodeToChar("f00d"); } }
		public static string times { get { return UnicodeToChar("f00d"); } }
		public static string search_plus { get { return UnicodeToChar("f00e"); } }
		public static string search_minus { get { return UnicodeToChar("f010"); } }
		public static string power_off { get { return UnicodeToChar("f011"); } }
		public static string signal { get { return UnicodeToChar("f012"); } }
		public static string gear { get { return UnicodeToChar("f013"); } }
		public static string cog { get { return UnicodeToChar("f013"); } }
		public static string trash_o { get { return UnicodeToChar("f014"); } }
		public static string home { get { return UnicodeToChar("f015"); } }
		public static string file_o { get { return UnicodeToChar("f016"); } }
		public static string clock_o { get { return UnicodeToChar("f017"); } }
		public static string road { get { return UnicodeToChar("f018"); } }
		public static string download { get { return UnicodeToChar("f019"); } }
		public static string arrow_circle_o_down { get { return UnicodeToChar("f01a"); } }
		public static string arrow_circle_o_up { get { return UnicodeToChar("f01b"); } }
		public static string inbox { get { return UnicodeToChar("f01c"); } }
		public static string play_circle_o { get { return UnicodeToChar("f01d"); } }
		public static string rotate_right { get { return UnicodeToChar("f01e"); } }
		public static string repeat { get { return UnicodeToChar("f01e"); } }
		public static string refresh { get { return UnicodeToChar("f021"); } }
		public static string list_alt { get { return UnicodeToChar("f022"); } }
		public static string @lock { get { return UnicodeToChar("f023"); } }
		public static string flag { get { return UnicodeToChar("f024"); } }
		public static string headphones { get { return UnicodeToChar("f025"); } }
		public static string volume_off { get { return UnicodeToChar("f026"); } }
		public static string volume_down { get { return UnicodeToChar("f027"); } }
		public static string volume_up { get { return UnicodeToChar("f028"); } }
		public static string qrcode { get { return UnicodeToChar("f029"); } }
		public static string barcode { get { return UnicodeToChar("f02a"); } }
		public static string tag { get { return UnicodeToChar("f02b"); } }
		public static string tags { get { return UnicodeToChar("f02c"); } }
		public static string book { get { return UnicodeToChar("f02d"); } }
		public static string bookmark { get { return UnicodeToChar("f02e"); } }
		public static string print { get { return UnicodeToChar("f02f"); } }
		public static string camera { get { return UnicodeToChar("f030"); } }
		public static string font { get { return UnicodeToChar("f031"); } }
		public static string bold { get { return UnicodeToChar("f032"); } }
		public static string italic { get { return UnicodeToChar("f033"); } }
		public static string text_height { get { return UnicodeToChar("f034"); } }
		public static string text_width { get { return UnicodeToChar("f035"); } }
		public static string align_left { get { return UnicodeToChar("f036"); } }
		public static string align_center { get { return UnicodeToChar("f037"); } }
		public static string align_right { get { return UnicodeToChar("f038"); } }
		public static string align_justify { get { return UnicodeToChar("f039"); } }
		public static string list { get { return UnicodeToChar("f03a"); } }
		public static string dedent { get { return UnicodeToChar("f03b"); } }
		public static string outdent { get { return UnicodeToChar("f03b"); } }
		public static string indent { get { return UnicodeToChar("f03c"); } }
		public static string video_camera { get { return UnicodeToChar("f03d"); } }
		public static string photo { get { return UnicodeToChar("f03e"); } }
		public static string image { get { return UnicodeToChar("f03e"); } }
		public static string picture_o { get { return UnicodeToChar("f03e"); } }
		public static string pencil { get { return UnicodeToChar("f040"); } }
		public static string map_marker { get { return UnicodeToChar("f041"); } }
		public static string adjust { get { return UnicodeToChar("f042"); } }
		public static string tint { get { return UnicodeToChar("f043"); } }
		public static string edit { get { return UnicodeToChar("f044"); } }
		public static string pencil_square_o { get { return UnicodeToChar("f044"); } }
		public static string share_square_o { get { return UnicodeToChar("f045"); } }
		public static string check_square_o { get { return UnicodeToChar("f046"); } }
		public static string arrows { get { return UnicodeToChar("f047"); } }
		public static string step_backward { get { return UnicodeToChar("f048"); } }
		public static string fast_backward { get { return UnicodeToChar("f049"); } }
		public static string backward { get { return UnicodeToChar("f04a"); } }
		public static string play { get { return UnicodeToChar("f04b"); } }
		public static string pause { get { return UnicodeToChar("f04c"); } }
		public static string stop { get { return UnicodeToChar("f04d"); } }
		public static string forward { get { return UnicodeToChar("f04e"); } }
		public static string fast_forward { get { return UnicodeToChar("f050"); } }
		public static string step_forward { get { return UnicodeToChar("f051"); } }
		public static string eject { get { return UnicodeToChar("f052"); } }
		public static string chevron_left { get { return UnicodeToChar("f053"); } }
		public static string chevron_right { get { return UnicodeToChar("f054"); } }
		public static string plus_circle { get { return UnicodeToChar("f055"); } }
		public static string minus_circle { get { return UnicodeToChar("f056"); } }
		public static string times_circle { get { return UnicodeToChar("f057"); } }
		public static string check_circle { get { return UnicodeToChar("f058"); } }
		public static string question_circle { get { return UnicodeToChar("f059"); } }
		public static string info_circle { get { return UnicodeToChar("f05a"); } }
		public static string crosshairs { get { return UnicodeToChar("f05b"); } }
		public static string times_circle_o { get { return UnicodeToChar("f05c"); } }
		public static string check_circle_o { get { return UnicodeToChar("f05d"); } }
		public static string ban { get { return UnicodeToChar("f05e"); } }
		public static string arrow_left { get { return UnicodeToChar("f060"); } }
		public static string arrow_right { get { return UnicodeToChar("f061"); } }
		public static string arrow_up { get { return UnicodeToChar("f062"); } }
		public static string arrow_down { get { return UnicodeToChar("f063"); } }
		public static string mail_forward { get { return UnicodeToChar("f064"); } }
		public static string share { get { return UnicodeToChar("f064"); } }
		public static string expand { get { return UnicodeToChar("f065"); } }
		public static string compress { get { return UnicodeToChar("f066"); } }
		public static string plus { get { return UnicodeToChar("f067"); } }
		public static string minus { get { return UnicodeToChar("f068"); } }
		public static string asterisk { get { return UnicodeToChar("f069"); } }
		public static string exclamation_circle { get { return UnicodeToChar("f06a"); } }
		public static string gift { get { return UnicodeToChar("f06b"); } }
		public static string leaf { get { return UnicodeToChar("f06c"); } }
		public static string fire { get { return UnicodeToChar("f06d"); } }
		public static string eye { get { return UnicodeToChar("f06e"); } }
		public static string eye_slash { get { return UnicodeToChar("f070"); } }
		public static string warning { get { return UnicodeToChar("f071"); } }
		public static string exclamation_triangle { get { return UnicodeToChar("f071"); } }
		public static string plane { get { return UnicodeToChar("f072"); } }
		public static string calendar { get { return UnicodeToChar("f073"); } }
		public static string random { get { return UnicodeToChar("f074"); } }
		public static string comment { get { return UnicodeToChar("f075"); } }
		public static string magnet { get { return UnicodeToChar("f076"); } }
		public static string chevron_up { get { return UnicodeToChar("f077"); } }
		public static string chevron_down { get { return UnicodeToChar("f078"); } }
		public static string retweet { get { return UnicodeToChar("f079"); } }
		public static string shopping_cart { get { return UnicodeToChar("f07a"); } }
		public static string folder { get { return UnicodeToChar("f07b"); } }
		public static string folder_open { get { return UnicodeToChar("f07c"); } }
		public static string arrows_v { get { return UnicodeToChar("f07d"); } }
		public static string arrows_h { get { return UnicodeToChar("f07e"); } }
		public static string bar_chart_o { get { return UnicodeToChar("f080"); } }
		public static string bar_chart { get { return UnicodeToChar("f080"); } }
		public static string twitter_square { get { return UnicodeToChar("f081"); } }
		public static string facebook_square { get { return UnicodeToChar("f082"); } }
		public static string camera_retro { get { return UnicodeToChar("f083"); } }
		public static string key { get { return UnicodeToChar("f084"); } }
		public static string gears { get { return UnicodeToChar("f085"); } }
		public static string cogs { get { return UnicodeToChar("f085"); } }
		public static string comments { get { return UnicodeToChar("f086"); } }
		public static string thumbs_o_up { get { return UnicodeToChar("f087"); } }
		public static string thumbs_o_down { get { return UnicodeToChar("f088"); } }
		public static string star_half { get { return UnicodeToChar("f089"); } }
		public static string heart_o { get { return UnicodeToChar("f08a"); } }
		public static string sign_out { get { return UnicodeToChar("f08b"); } }
		public static string linkedin_square { get { return UnicodeToChar("f08c"); } }
		public static string thumb_tack { get { return UnicodeToChar("f08d"); } }
		public static string external_link { get { return UnicodeToChar("f08e"); } }
		public static string sign_in { get { return UnicodeToChar("f090"); } }
		public static string trophy { get { return UnicodeToChar("f091"); } }
		public static string github_square { get { return UnicodeToChar("f092"); } }
		public static string upload { get { return UnicodeToChar("f093"); } }
		public static string lemon_o { get { return UnicodeToChar("f094"); } }
		public static string phone { get { return UnicodeToChar("f095"); } }
		public static string square_o { get { return UnicodeToChar("f096"); } }
		public static string bookmark_o { get { return UnicodeToChar("f097"); } }
		public static string phone_square { get { return UnicodeToChar("f098"); } }
		public static string twitter { get { return UnicodeToChar("f099"); } }
		public static string facebook_f { get { return UnicodeToChar("f09a"); } }
		public static string facebook { get { return UnicodeToChar("f09a"); } }
		public static string github { get { return UnicodeToChar("f09b"); } }
		public static string unlock { get { return UnicodeToChar("f09c"); } }
		public static string credit_card { get { return UnicodeToChar("f09d"); } }
		public static string feed { get { return UnicodeToChar("f09e"); } }
		public static string rss { get { return UnicodeToChar("f09e"); } }
		public static string hdd_o { get { return UnicodeToChar("f0a0"); } }
		public static string bullhorn { get { return UnicodeToChar("f0a1"); } }
		public static string bell { get { return UnicodeToChar("f0f3"); } }
		public static string certificate { get { return UnicodeToChar("f0a3"); } }
		public static string hand_o_right { get { return UnicodeToChar("f0a4"); } }
		public static string hand_o_left { get { return UnicodeToChar("f0a5"); } }
		public static string hand_o_up { get { return UnicodeToChar("f0a6"); } }
		public static string hand_o_down { get { return UnicodeToChar("f0a7"); } }
		public static string arrow_circle_left { get { return UnicodeToChar("f0a8"); } }
		public static string arrow_circle_right { get { return UnicodeToChar("f0a9"); } }
		public static string arrow_circle_up { get { return UnicodeToChar("f0aa"); } }
		public static string arrow_circle_down { get { return UnicodeToChar("f0ab"); } }
		public static string globe { get { return UnicodeToChar("f0ac"); } }
		public static string wrench { get { return UnicodeToChar("f0ad"); } }
		public static string tasks { get { return UnicodeToChar("f0ae"); } }
		public static string filter { get { return UnicodeToChar("f0b0"); } }
		public static string briefcase { get { return UnicodeToChar("f0b1"); } }
		public static string arrows_alt { get { return UnicodeToChar("f0b2"); } }
		public static string group { get { return UnicodeToChar("f0c0"); } }
		public static string users { get { return UnicodeToChar("f0c0"); } }
		public static string chain { get { return UnicodeToChar("f0c1"); } }
		public static string link { get { return UnicodeToChar("f0c1"); } }
		public static string cloud { get { return UnicodeToChar("f0c2"); } }
		public static string flask { get { return UnicodeToChar("f0c3"); } }
		public static string cut { get { return UnicodeToChar("f0c4"); } }
		public static string scissors { get { return UnicodeToChar("f0c4"); } }
		public static string copy { get { return UnicodeToChar("f0c5"); } }
		public static string files_o { get { return UnicodeToChar("f0c5"); } }
		public static string paperclip { get { return UnicodeToChar("f0c6"); } }
		public static string save { get { return UnicodeToChar("f0c7"); } }
		public static string floppy_o { get { return UnicodeToChar("f0c7"); } }
		public static string square { get { return UnicodeToChar("f0c8"); } }
		public static string navicon { get { return UnicodeToChar("f0c9"); } }
		public static string reorder { get { return UnicodeToChar("f0c9"); } }
		public static string bars { get { return UnicodeToChar("f0c9"); } }
		public static string list_ul { get { return UnicodeToChar("f0ca"); } }
		public static string list_ol { get { return UnicodeToChar("f0cb"); } }
		public static string strikethrough { get { return UnicodeToChar("f0cc"); } }
		public static string underline { get { return UnicodeToChar("f0cd"); } }
		public static string table { get { return UnicodeToChar("f0ce"); } }
		public static string magic { get { return UnicodeToChar("f0d0"); } }
		public static string truck { get { return UnicodeToChar("f0d1"); } }
		public static string pinterest { get { return UnicodeToChar("f0d2"); } }
		public static string pinterest_square { get { return UnicodeToChar("f0d3"); } }
		public static string google_plus_square { get { return UnicodeToChar("f0d4"); } }
		public static string google_plus { get { return UnicodeToChar("f0d5"); } }
		public static string money { get { return UnicodeToChar("f0d6"); } }
		public static string caret_down { get { return UnicodeToChar("f0d7"); } }
		public static string caret_up { get { return UnicodeToChar("f0d8"); } }
		public static string caret_left { get { return UnicodeToChar("f0d9"); } }
		public static string caret_right { get { return UnicodeToChar("f0da"); } }
		public static string columns { get { return UnicodeToChar("f0db"); } }
		public static string unsorted { get { return UnicodeToChar("f0dc"); } }
		public static string sort { get { return UnicodeToChar("f0dc"); } }
		public static string sort_down { get { return UnicodeToChar("f0dd"); } }
		public static string sort_desc { get { return UnicodeToChar("f0dd"); } }
		public static string sort_up { get { return UnicodeToChar("f0de"); } }
		public static string sort_asc { get { return UnicodeToChar("f0de"); } }
		public static string envelope { get { return UnicodeToChar("f0e0"); } }
		public static string linkedin { get { return UnicodeToChar("f0e1"); } }
		public static string rotate_left { get { return UnicodeToChar("f0e2"); } }
		public static string undo { get { return UnicodeToChar("f0e2"); } }
		public static string legal { get { return UnicodeToChar("f0e3"); } }
		public static string gavel { get { return UnicodeToChar("f0e3"); } }
		public static string dashboard { get { return UnicodeToChar("f0e4"); } }
		public static string tachometer { get { return UnicodeToChar("f0e4"); } }
		public static string comment_o { get { return UnicodeToChar("f0e5"); } }
		public static string comments_o { get { return UnicodeToChar("f0e6"); } }
		public static string flash { get { return UnicodeToChar("f0e7"); } }
		public static string bolt { get { return UnicodeToChar("f0e7"); } }
		public static string sitemap { get { return UnicodeToChar("f0e8"); } }
		public static string umbrella { get { return UnicodeToChar("f0e9"); } }
		public static string paste { get { return UnicodeToChar("f0ea"); } }
		public static string clipboard { get { return UnicodeToChar("f0ea"); } }
		public static string lightbulb_o { get { return UnicodeToChar("f0eb"); } }
		public static string exchange { get { return UnicodeToChar("f0ec"); } }
		public static string cloud_download { get { return UnicodeToChar("f0ed"); } }
		public static string cloud_upload { get { return UnicodeToChar("f0ee"); } }
		public static string user_md { get { return UnicodeToChar("f0f0"); } }
		public static string stethoscope { get { return UnicodeToChar("f0f1"); } }
		public static string suitcase { get { return UnicodeToChar("f0f2"); } }
		public static string bell_o { get { return UnicodeToChar("f0a2"); } }
		public static string coffee { get { return UnicodeToChar("f0f4"); } }
		public static string cutlery { get { return UnicodeToChar("f0f5"); } }
		public static string file_text_o { get { return UnicodeToChar("f0f6"); } }
		public static string building_o { get { return UnicodeToChar("f0f7"); } }
		public static string hospital_o { get { return UnicodeToChar("f0f8"); } }
		public static string ambulance { get { return UnicodeToChar("f0f9"); } }
		public static string medkit { get { return UnicodeToChar("f0fa"); } }
		public static string fighter_jet { get { return UnicodeToChar("f0fb"); } }
		public static string beer { get { return UnicodeToChar("f0fc"); } }
		public static string h_square { get { return UnicodeToChar("f0fd"); } }
		public static string plus_square { get { return UnicodeToChar("f0fe"); } }
		public static string angle_double_left { get { return UnicodeToChar("f100"); } }
		public static string angle_double_right { get { return UnicodeToChar("f101"); } }
		public static string angle_double_up { get { return UnicodeToChar("f102"); } }
		public static string angle_double_down { get { return UnicodeToChar("f103"); } }
		public static string angle_left { get { return UnicodeToChar("f104"); } }
		public static string angle_right { get { return UnicodeToChar("f105"); } }
		public static string angle_up { get { return UnicodeToChar("f106"); } }
		public static string angle_down { get { return UnicodeToChar("f107"); } }
		public static string desktop { get { return UnicodeToChar("f108"); } }
		public static string laptop { get { return UnicodeToChar("f109"); } }
		public static string tablet { get { return UnicodeToChar("f10a"); } }
		public static string mobile_phone { get { return UnicodeToChar("f10b"); } }
		public static string mobile { get { return UnicodeToChar("f10b"); } }
		public static string circle_o { get { return UnicodeToChar("f10c"); } }
		public static string quote_left { get { return UnicodeToChar("f10d"); } }
		public static string quote_right { get { return UnicodeToChar("f10e"); } }
		public static string spinner { get { return UnicodeToChar("f110"); } }
		public static string circle { get { return UnicodeToChar("f111"); } }
		public static string mail_reply { get { return UnicodeToChar("f112"); } }
		public static string reply { get { return UnicodeToChar("f112"); } }
		public static string github_alt { get { return UnicodeToChar("f113"); } }
		public static string folder_o { get { return UnicodeToChar("f114"); } }
		public static string folder_open_o { get { return UnicodeToChar("f115"); } }
		public static string smile_o { get { return UnicodeToChar("f118"); } }
		public static string frown_o { get { return UnicodeToChar("f119"); } }
		public static string meh_o { get { return UnicodeToChar("f11a"); } }
		public static string gamepad { get { return UnicodeToChar("f11b"); } }
		public static string keyboard_o { get { return UnicodeToChar("f11c"); } }
		public static string flag_o { get { return UnicodeToChar("f11d"); } }
		public static string flag_checkered { get { return UnicodeToChar("f11e"); } }
		public static string terminal { get { return UnicodeToChar("f120"); } }
		public static string code { get { return UnicodeToChar("f121"); } }
		public static string mail_reply_all { get { return UnicodeToChar("f122"); } }
		public static string reply_all { get { return UnicodeToChar("f122"); } }
		public static string star_half_empty { get { return UnicodeToChar("f123"); } }
		public static string star_half_full { get { return UnicodeToChar("f123"); } }
		public static string star_half_o { get { return UnicodeToChar("f123"); } }
		public static string location_arrow { get { return UnicodeToChar("f124"); } }
		public static string crop { get { return UnicodeToChar("f125"); } }
		public static string code_fork { get { return UnicodeToChar("f126"); } }
		public static string unlink { get { return UnicodeToChar("f127"); } }
		public static string chain_broken { get { return UnicodeToChar("f127"); } }
		public static string question { get { return UnicodeToChar("f128"); } }
		public static string info { get { return UnicodeToChar("f129"); } }
		public static string exclamation { get { return UnicodeToChar("f12a"); } }
		public static string superscript { get { return UnicodeToChar("f12b"); } }
		public static string subscript { get { return UnicodeToChar("f12c"); } }
		public static string eraser { get { return UnicodeToChar("f12d"); } }
		public static string puzzle_piece { get { return UnicodeToChar("f12e"); } }
		public static string microphone { get { return UnicodeToChar("f130"); } }
		public static string microphone_slash { get { return UnicodeToChar("f131"); } }
		public static string shield { get { return UnicodeToChar("f132"); } }
		public static string calendar_o { get { return UnicodeToChar("f133"); } }
		public static string fire_extinguisher { get { return UnicodeToChar("f134"); } }
		public static string rocket { get { return UnicodeToChar("f135"); } }
		public static string maxcdn { get { return UnicodeToChar("f136"); } }
		public static string chevron_circle_left { get { return UnicodeToChar("f137"); } }
		public static string chevron_circle_right { get { return UnicodeToChar("f138"); } }
		public static string chevron_circle_up { get { return UnicodeToChar("f139"); } }
		public static string chevron_circle_down { get { return UnicodeToChar("f13a"); } }
		public static string html5 { get { return UnicodeToChar("f13b"); } }
		public static string css3 { get { return UnicodeToChar("f13c"); } }
		public static string anchor { get { return UnicodeToChar("f13d"); } }
		public static string unlock_alt { get { return UnicodeToChar("f13e"); } }
		public static string bullseye { get { return UnicodeToChar("f140"); } }
		public static string ellipsis_h { get { return UnicodeToChar("f141"); } }
		public static string ellipsis_v { get { return UnicodeToChar("f142"); } }
		public static string rss_square { get { return UnicodeToChar("f143"); } }
		public static string play_circle { get { return UnicodeToChar("f144"); } }
		public static string ticket { get { return UnicodeToChar("f145"); } }
		public static string minus_square { get { return UnicodeToChar("f146"); } }
		public static string minus_square_o { get { return UnicodeToChar("f147"); } }
		public static string level_up { get { return UnicodeToChar("f148"); } }
		public static string level_down { get { return UnicodeToChar("f149"); } }
		public static string check_square { get { return UnicodeToChar("f14a"); } }
		public static string pencil_square { get { return UnicodeToChar("f14b"); } }
		public static string external_link_square { get { return UnicodeToChar("f14c"); } }
		public static string share_square { get { return UnicodeToChar("f14d"); } }
		public static string compass { get { return UnicodeToChar("f14e"); } }
		public static string toggle_down { get { return UnicodeToChar("f150"); } }
		public static string caret_square_o_down { get { return UnicodeToChar("f150"); } }
		public static string toggle_up { get { return UnicodeToChar("f151"); } }
		public static string caret_square_o_up { get { return UnicodeToChar("f151"); } }
		public static string toggle_right { get { return UnicodeToChar("f152"); } }
		public static string caret_square_o_right { get { return UnicodeToChar("f152"); } }
		public static string euro { get { return UnicodeToChar("f153"); } }
		public static string eur { get { return UnicodeToChar("f153"); } }
		public static string gbp { get { return UnicodeToChar("f154"); } }
		public static string dollar { get { return UnicodeToChar("f155"); } }
		public static string usd { get { return UnicodeToChar("f155"); } }
		public static string rupee { get { return UnicodeToChar("f156"); } }
		public static string inr { get { return UnicodeToChar("f156"); } }
		public static string cny { get { return UnicodeToChar("f157"); } }
		public static string rmb { get { return UnicodeToChar("f157"); } }
		public static string yen { get { return UnicodeToChar("f157"); } }
		public static string jpy { get { return UnicodeToChar("f157"); } }
		public static string ruble { get { return UnicodeToChar("f158"); } }
		public static string rouble { get { return UnicodeToChar("f158"); } }
		public static string rub { get { return UnicodeToChar("f158"); } }
		public static string won { get { return UnicodeToChar("f159"); } }
		public static string krw { get { return UnicodeToChar("f159"); } }
		public static string bitcoin { get { return UnicodeToChar("f15a"); } }
		public static string btc { get { return UnicodeToChar("f15a"); } }
		public static string file { get { return UnicodeToChar("f15b"); } }
		public static string file_text { get { return UnicodeToChar("f15c"); } }
		public static string sort_alpha_asc { get { return UnicodeToChar("f15d"); } }
		public static string sort_alpha_desc { get { return UnicodeToChar("f15e"); } }
		public static string sort_amount_asc { get { return UnicodeToChar("f160"); } }
		public static string sort_amount_desc { get { return UnicodeToChar("f161"); } }
		public static string sort_numeric_asc { get { return UnicodeToChar("f162"); } }
		public static string sort_numeric_desc { get { return UnicodeToChar("f163"); } }
		public static string thumbs_up { get { return UnicodeToChar("f164"); } }
		public static string thumbs_down { get { return UnicodeToChar("f165"); } }
		public static string youtube_square { get { return UnicodeToChar("f166"); } }
		public static string youtube { get { return UnicodeToChar("f167"); } }
		public static string xing { get { return UnicodeToChar("f168"); } }
		public static string xing_square { get { return UnicodeToChar("f169"); } }
		public static string youtube_play { get { return UnicodeToChar("f16a"); } }
		public static string dropbox { get { return UnicodeToChar("f16b"); } }
		public static string stack_overflow { get { return UnicodeToChar("f16c"); } }
		public static string instagram { get { return UnicodeToChar("f16d"); } }
		public static string flickr { get { return UnicodeToChar("f16e"); } }
		public static string adn { get { return UnicodeToChar("f170"); } }
		public static string bitbucket { get { return UnicodeToChar("f171"); } }
		public static string bitbucket_square { get { return UnicodeToChar("f172"); } }
		public static string tumblr { get { return UnicodeToChar("f173"); } }
		public static string tumblr_square { get { return UnicodeToChar("f174"); } }
		public static string long_arrow_down { get { return UnicodeToChar("f175"); } }
		public static string long_arrow_up { get { return UnicodeToChar("f176"); } }
		public static string long_arrow_left { get { return UnicodeToChar("f177"); } }
		public static string long_arrow_right { get { return UnicodeToChar("f178"); } }
		public static string apple { get { return UnicodeToChar("f179"); } }
		public static string windows { get { return UnicodeToChar("f17a"); } }
		public static string android { get { return UnicodeToChar("f17b"); } }
		public static string linux { get { return UnicodeToChar("f17c"); } }
		public static string dribbble { get { return UnicodeToChar("f17d"); } }
		public static string skype { get { return UnicodeToChar("f17e"); } }
		public static string foursquare { get { return UnicodeToChar("f180"); } }
		public static string trello { get { return UnicodeToChar("f181"); } }
		public static string female { get { return UnicodeToChar("f182"); } }
		public static string male { get { return UnicodeToChar("f183"); } }
		public static string gittip { get { return UnicodeToChar("f184"); } }
		public static string gratipay { get { return UnicodeToChar("f184"); } }
		public static string sun_o { get { return UnicodeToChar("f185"); } }
		public static string moon_o { get { return UnicodeToChar("f186"); } }
		public static string archive { get { return UnicodeToChar("f187"); } }
		public static string bug { get { return UnicodeToChar("f188"); } }
		public static string vk { get { return UnicodeToChar("f189"); } }
		public static string weibo { get { return UnicodeToChar("f18a"); } }
		public static string renren { get { return UnicodeToChar("f18b"); } }
		public static string pagelines { get { return UnicodeToChar("f18c"); } }
		public static string stack_exchange { get { return UnicodeToChar("f18d"); } }
		public static string arrow_circle_o_right { get { return UnicodeToChar("f18e"); } }
		public static string arrow_circle_o_left { get { return UnicodeToChar("f190"); } }
		public static string toggle_left { get { return UnicodeToChar("f191"); } }
		public static string caret_square_o_left { get { return UnicodeToChar("f191"); } }
		public static string dot_circle_o { get { return UnicodeToChar("f192"); } }
		public static string wheelchair { get { return UnicodeToChar("f193"); } }
		public static string vimeo_square { get { return UnicodeToChar("f194"); } }
		public static string turkish_lira { get { return UnicodeToChar("f195"); } }
		public static string @try { get { return UnicodeToChar("f195"); } }
		public static string plus_square_o { get { return UnicodeToChar("f196"); } }
		public static string space_shuttle { get { return UnicodeToChar("f197"); } }
		public static string slack { get { return UnicodeToChar("f198"); } }
		public static string envelope_square { get { return UnicodeToChar("f199"); } }
		public static string wordpress { get { return UnicodeToChar("f19a"); } }
		public static string openid { get { return UnicodeToChar("f19b"); } }
		public static string institution { get { return UnicodeToChar("f19c"); } }
		public static string bank { get { return UnicodeToChar("f19c"); } }
		public static string university { get { return UnicodeToChar("f19c"); } }
		public static string mortar_board { get { return UnicodeToChar("f19d"); } }
		public static string graduation_cap { get { return UnicodeToChar("f19d"); } }
		public static string yahoo { get { return UnicodeToChar("f19e"); } }
		public static string google { get { return UnicodeToChar("f1a0"); } }
		public static string reddit { get { return UnicodeToChar("f1a1"); } }
		public static string reddit_square { get { return UnicodeToChar("f1a2"); } }
		public static string stumbleupon_circle { get { return UnicodeToChar("f1a3"); } }
		public static string stumbleupon { get { return UnicodeToChar("f1a4"); } }
		public static string delicious { get { return UnicodeToChar("f1a5"); } }
		public static string digg { get { return UnicodeToChar("f1a6"); } }
		public static string pied_piper { get { return UnicodeToChar("f1a7"); } }
		public static string pied_piper_alt { get { return UnicodeToChar("f1a8"); } }
		public static string drupal { get { return UnicodeToChar("f1a9"); } }
		public static string joomla { get { return UnicodeToChar("f1aa"); } }
		public static string language { get { return UnicodeToChar("f1ab"); } }
		public static string fax { get { return UnicodeToChar("f1ac"); } }
		public static string building { get { return UnicodeToChar("f1ad"); } }
		public static string child { get { return UnicodeToChar("f1ae"); } }
		public static string paw { get { return UnicodeToChar("f1b0"); } }
		public static string spoon { get { return UnicodeToChar("f1b1"); } }
		public static string cube { get { return UnicodeToChar("f1b2"); } }
		public static string cubes { get { return UnicodeToChar("f1b3"); } }
		public static string behance { get { return UnicodeToChar("f1b4"); } }
		public static string behance_square { get { return UnicodeToChar("f1b5"); } }
		public static string steam { get { return UnicodeToChar("f1b6"); } }
		public static string steam_square { get { return UnicodeToChar("f1b7"); } }
		public static string recycle { get { return UnicodeToChar("f1b8"); } }
		public static string automobile { get { return UnicodeToChar("f1b9"); } }
		public static string car { get { return UnicodeToChar("f1b9"); } }
		public static string cab { get { return UnicodeToChar("f1ba"); } }
		public static string taxi { get { return UnicodeToChar("f1ba"); } }
		public static string tree { get { return UnicodeToChar("f1bb"); } }
		public static string spotify { get { return UnicodeToChar("f1bc"); } }
		public static string deviantart { get { return UnicodeToChar("f1bd"); } }
		public static string soundcloud { get { return UnicodeToChar("f1be"); } }
		public static string database { get { return UnicodeToChar("f1c0"); } }
		public static string file_pdf_o { get { return UnicodeToChar("f1c1"); } }
		public static string file_word_o { get { return UnicodeToChar("f1c2"); } }
		public static string file_excel_o { get { return UnicodeToChar("f1c3"); } }
		public static string file_powerpoint_o { get { return UnicodeToChar("f1c4"); } }
		public static string file_photo_o { get { return UnicodeToChar("f1c5"); } }
		public static string file_picture_o { get { return UnicodeToChar("f1c5"); } }
		public static string file_image_o { get { return UnicodeToChar("f1c5"); } }
		public static string file_zip_o { get { return UnicodeToChar("f1c6"); } }
		public static string file_archive_o { get { return UnicodeToChar("f1c6"); } }
		public static string file_sound_o { get { return UnicodeToChar("f1c7"); } }
		public static string file_audio_o { get { return UnicodeToChar("f1c7"); } }
		public static string file_movie_o { get { return UnicodeToChar("f1c8"); } }
		public static string file_video_o { get { return UnicodeToChar("f1c8"); } }
		public static string file_code_o { get { return UnicodeToChar("f1c9"); } }
		public static string vine { get { return UnicodeToChar("f1ca"); } }
		public static string codepen { get { return UnicodeToChar("f1cb"); } }
		public static string jsfiddle { get { return UnicodeToChar("f1cc"); } }
		public static string life_bouy { get { return UnicodeToChar("f1cd"); } }
		public static string life_buoy { get { return UnicodeToChar("f1cd"); } }
		public static string life_saver { get { return UnicodeToChar("f1cd"); } }
		public static string support { get { return UnicodeToChar("f1cd"); } }
		public static string life_ring { get { return UnicodeToChar("f1cd"); } }
		public static string circle_o_notch { get { return UnicodeToChar("f1ce"); } }
		public static string ra { get { return UnicodeToChar("f1d0"); } }
		public static string rebel { get { return UnicodeToChar("f1d0"); } }
		public static string ge { get { return UnicodeToChar("f1d1"); } }
		public static string empire { get { return UnicodeToChar("f1d1"); } }
		public static string git_square { get { return UnicodeToChar("f1d2"); } }
		public static string git { get { return UnicodeToChar("f1d3"); } }
		public static string y_combinator_square { get { return UnicodeToChar("f1d4"); } }
		public static string yc_square { get { return UnicodeToChar("f1d4"); } }
		public static string hacker_news { get { return UnicodeToChar("f1d4"); } }
		public static string tencent_weibo { get { return UnicodeToChar("f1d5"); } }
		public static string qq { get { return UnicodeToChar("f1d6"); } }
		public static string wechat { get { return UnicodeToChar("f1d7"); } }
		public static string weixin { get { return UnicodeToChar("f1d7"); } }
		public static string send { get { return UnicodeToChar("f1d8"); } }
		public static string paper_plane { get { return UnicodeToChar("f1d8"); } }
		public static string send_o { get { return UnicodeToChar("f1d9"); } }
		public static string paper_plane_o { get { return UnicodeToChar("f1d9"); } }
		public static string history { get { return UnicodeToChar("f1da"); } }
		public static string circle_thin { get { return UnicodeToChar("f1db"); } }
		public static string header { get { return UnicodeToChar("f1dc"); } }
		public static string paragraph { get { return UnicodeToChar("f1dd"); } }
		public static string sliders { get { return UnicodeToChar("f1de"); } }
		public static string share_alt { get { return UnicodeToChar("f1e0"); } }
		public static string share_alt_square { get { return UnicodeToChar("f1e1"); } }
		public static string bomb { get { return UnicodeToChar("f1e2"); } }
		public static string soccer_ball_o { get { return UnicodeToChar("f1e3"); } }
		public static string futbol_o { get { return UnicodeToChar("f1e3"); } }
		public static string tty { get { return UnicodeToChar("f1e4"); } }
		public static string binoculars { get { return UnicodeToChar("f1e5"); } }
		public static string plug { get { return UnicodeToChar("f1e6"); } }
		public static string slideshare { get { return UnicodeToChar("f1e7"); } }
		public static string twitch { get { return UnicodeToChar("f1e8"); } }
		public static string yelp { get { return UnicodeToChar("f1e9"); } }
		public static string newspaper_o { get { return UnicodeToChar("f1ea"); } }
		public static string wifi { get { return UnicodeToChar("f1eb"); } }
		public static string calculator { get { return UnicodeToChar("f1ec"); } }
		public static string paypal { get { return UnicodeToChar("f1ed"); } }
		public static string google_wallet { get { return UnicodeToChar("f1ee"); } }
		public static string cc_visa { get { return UnicodeToChar("f1f0"); } }
		public static string cc_mastercard { get { return UnicodeToChar("f1f1"); } }
		public static string cc_discover { get { return UnicodeToChar("f1f2"); } }
		public static string cc_amex { get { return UnicodeToChar("f1f3"); } }
		public static string cc_paypal { get { return UnicodeToChar("f1f4"); } }
		public static string cc_stripe { get { return UnicodeToChar("f1f5"); } }
		public static string bell_slash { get { return UnicodeToChar("f1f6"); } }
		public static string bell_slash_o { get { return UnicodeToChar("f1f7"); } }
		public static string trash { get { return UnicodeToChar("f1f8"); } }
		public static string copyright { get { return UnicodeToChar("f1f9"); } }
		public static string at { get { return UnicodeToChar("f1fa"); } }
		public static string eyedropper { get { return UnicodeToChar("f1fb"); } }
		public static string paint_brush { get { return UnicodeToChar("f1fc"); } }
		public static string birthday_cake { get { return UnicodeToChar("f1fd"); } }
		public static string area_chart { get { return UnicodeToChar("f1fe"); } }
		public static string pie_chart { get { return UnicodeToChar("f200"); } }
		public static string line_chart { get { return UnicodeToChar("f201"); } }
		public static string lastfm { get { return UnicodeToChar("f202"); } }
		public static string lastfm_square { get { return UnicodeToChar("f203"); } }
		public static string toggle_off { get { return UnicodeToChar("f204"); } }
		public static string toggle_on { get { return UnicodeToChar("f205"); } }
		public static string bicycle { get { return UnicodeToChar("f206"); } }
		public static string bus { get { return UnicodeToChar("f207"); } }
		public static string ioxhost { get { return UnicodeToChar("f208"); } }
		public static string angellist { get { return UnicodeToChar("f209"); } }
		public static string cc { get { return UnicodeToChar("f20a"); } }
		public static string shekel { get { return UnicodeToChar("f20b"); } }
		public static string sheqel { get { return UnicodeToChar("f20b"); } }
		public static string ils { get { return UnicodeToChar("f20b"); } }
		public static string meanpath { get { return UnicodeToChar("f20c"); } }
		public static string buysellads { get { return UnicodeToChar("f20d"); } }
		public static string connectdevelop { get { return UnicodeToChar("f20e"); } }
		public static string dashcube { get { return UnicodeToChar("f210"); } }
		public static string forumbee { get { return UnicodeToChar("f211"); } }
		public static string leanpub { get { return UnicodeToChar("f212"); } }
		public static string sellsy { get { return UnicodeToChar("f213"); } }
		public static string shirtsinbulk { get { return UnicodeToChar("f214"); } }
		public static string simplybuilt { get { return UnicodeToChar("f215"); } }
		public static string skyatlas { get { return UnicodeToChar("f216"); } }
		public static string cart_plus { get { return UnicodeToChar("f217"); } }
		public static string cart_arrow_down { get { return UnicodeToChar("f218"); } }
		public static string diamond { get { return UnicodeToChar("f219"); } }
		public static string ship { get { return UnicodeToChar("f21a"); } }
		public static string user_secret { get { return UnicodeToChar("f21b"); } }
		public static string motorcycle { get { return UnicodeToChar("f21c"); } }
		public static string street_view { get { return UnicodeToChar("f21d"); } }
		public static string heartbeat { get { return UnicodeToChar("f21e"); } }
		public static string venus { get { return UnicodeToChar("f221"); } }
		public static string mars { get { return UnicodeToChar("f222"); } }
		public static string mercury { get { return UnicodeToChar("f223"); } }
		public static string intersex { get { return UnicodeToChar("f224"); } }
		public static string transgender { get { return UnicodeToChar("f224"); } }
		public static string transgender_alt { get { return UnicodeToChar("f225"); } }
		public static string venus_double { get { return UnicodeToChar("f226"); } }
		public static string mars_double { get { return UnicodeToChar("f227"); } }
		public static string venus_mars { get { return UnicodeToChar("f228"); } }
		public static string mars_stroke { get { return UnicodeToChar("f229"); } }
		public static string mars_stroke_v { get { return UnicodeToChar("f22a"); } }
		public static string mars_stroke_h { get { return UnicodeToChar("f22b"); } }
		public static string neuter { get { return UnicodeToChar("f22c"); } }
		public static string genderless { get { return UnicodeToChar("f22d"); } }
		public static string facebook_official { get { return UnicodeToChar("f230"); } }
		public static string pinterest_p { get { return UnicodeToChar("f231"); } }
		public static string whatsapp { get { return UnicodeToChar("f232"); } }
		public static string server { get { return UnicodeToChar("f233"); } }
		public static string user_plus { get { return UnicodeToChar("f234"); } }
		public static string user_times { get { return UnicodeToChar("f235"); } }
		public static string hotel { get { return UnicodeToChar("f236"); } }
		public static string bed { get { return UnicodeToChar("f236"); } }
		public static string viacoin { get { return UnicodeToChar("f237"); } }
		public static string train { get { return UnicodeToChar("f238"); } }
		public static string subway { get { return UnicodeToChar("f239"); } }
		public static string medium { get { return UnicodeToChar("f23a"); } }
		public static string yc { get { return UnicodeToChar("f23b"); } }
		public static string y_combinator { get { return UnicodeToChar("f23b"); } }
		public static string optin_monster { get { return UnicodeToChar("f23c"); } }
		public static string opencart { get { return UnicodeToChar("f23d"); } }
		public static string expeditedssl { get { return UnicodeToChar("f23e"); } }
		public static string battery_4 { get { return UnicodeToChar("f240"); } }
		public static string battery_full { get { return UnicodeToChar("f240"); } }
		public static string battery_3 { get { return UnicodeToChar("f241"); } }
		public static string battery_three_quarters { get { return UnicodeToChar("f241"); } }
		public static string battery_2 { get { return UnicodeToChar("f242"); } }
		public static string battery_half { get { return UnicodeToChar("f242"); } }
		public static string battery_1 { get { return UnicodeToChar("f243"); } }
		public static string battery_quarter { get { return UnicodeToChar("f243"); } }
		public static string battery_0 { get { return UnicodeToChar("f244"); } }
		public static string battery_empty { get { return UnicodeToChar("f244"); } }
		public static string mouse_pointer { get { return UnicodeToChar("f245"); } }
		public static string i_cursor { get { return UnicodeToChar("f246"); } }
		public static string object_group { get { return UnicodeToChar("f247"); } }
		public static string object_ungroup { get { return UnicodeToChar("f248"); } }
		public static string sticky_note { get { return UnicodeToChar("f249"); } }
		public static string sticky_note_o { get { return UnicodeToChar("f24a"); } }
		public static string cc_jcb { get { return UnicodeToChar("f24b"); } }
		public static string cc_diners_club { get { return UnicodeToChar("f24c"); } }
		public static string clone { get { return UnicodeToChar("f24d"); } }
		public static string balance_scale { get { return UnicodeToChar("f24e"); } }
		public static string hourglass_o { get { return UnicodeToChar("f250"); } }
		public static string hourglass_1 { get { return UnicodeToChar("f251"); } }
		public static string hourglass_start { get { return UnicodeToChar("f251"); } }
		public static string hourglass_2 { get { return UnicodeToChar("f252"); } }
		public static string hourglass_half { get { return UnicodeToChar("f252"); } }
		public static string hourglass_3 { get { return UnicodeToChar("f253"); } }
		public static string hourglass_end { get { return UnicodeToChar("f253"); } }
		public static string hourglass { get { return UnicodeToChar("f254"); } }
		public static string hand_grab_o { get { return UnicodeToChar("f255"); } }
		public static string hand_rock_o { get { return UnicodeToChar("f255"); } }
		public static string hand_stop_o { get { return UnicodeToChar("f256"); } }
		public static string hand_paper_o { get { return UnicodeToChar("f256"); } }
		public static string hand_scissors_o { get { return UnicodeToChar("f257"); } }
		public static string hand_lizard_o { get { return UnicodeToChar("f258"); } }
		public static string hand_spock_o { get { return UnicodeToChar("f259"); } }
		public static string hand_pointer_o { get { return UnicodeToChar("f25a"); } }
		public static string hand_peace_o { get { return UnicodeToChar("f25b"); } }
		public static string trademark { get { return UnicodeToChar("f25c"); } }
		public static string registered { get { return UnicodeToChar("f25d"); } }
		public static string creative_commons { get { return UnicodeToChar("f25e"); } }
		public static string gg { get { return UnicodeToChar("f260"); } }
		public static string gg_circle { get { return UnicodeToChar("f261"); } }
		public static string tripadvisor { get { return UnicodeToChar("f262"); } }
		public static string odnoklassniki { get { return UnicodeToChar("f263"); } }
		public static string odnoklassniki_square { get { return UnicodeToChar("f264"); } }
		public static string get_pocket { get { return UnicodeToChar("f265"); } }
		public static string wikipedia_w { get { return UnicodeToChar("f266"); } }
		public static string safari { get { return UnicodeToChar("f267"); } }
		public static string chrome { get { return UnicodeToChar("f268"); } }
		public static string firefox { get { return UnicodeToChar("f269"); } }
		public static string opera { get { return UnicodeToChar("f26a"); } }
		public static string internet_explorer { get { return UnicodeToChar("f26b"); } }
		public static string tv { get { return UnicodeToChar("f26c"); } }
		public static string television { get { return UnicodeToChar("f26c"); } }
		public static string contao { get { return UnicodeToChar("f26d"); } }
		public static string _500px { get { return UnicodeToChar("f26e"); } }
		public static string amazon { get { return UnicodeToChar("f270"); } }
		public static string calendar_plus_o { get { return UnicodeToChar("f271"); } }
		public static string calendar_minus_o { get { return UnicodeToChar("f272"); } }
		public static string calendar_times_o { get { return UnicodeToChar("f273"); } }
		public static string calendar_check_o { get { return UnicodeToChar("f274"); } }
		public static string industry { get { return UnicodeToChar("f275"); } }
		public static string map_pin { get { return UnicodeToChar("f276"); } }
		public static string map_signs { get { return UnicodeToChar("f277"); } }
		public static string map_o { get { return UnicodeToChar("f278"); } }
		public static string map { get { return UnicodeToChar("f279"); } }
		public static string commenting { get { return UnicodeToChar("f27a"); } }
		public static string commenting_o { get { return UnicodeToChar("f27b"); } }
		public static string houzz { get { return UnicodeToChar("f27c"); } }
		public static string vimeo { get { return UnicodeToChar("f27d"); } }
		public static string black_tie { get { return UnicodeToChar("f27e"); } }
		public static string fonticons { get { return UnicodeToChar("f280"); } }
	}
}