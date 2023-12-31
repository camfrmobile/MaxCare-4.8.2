﻿using System;

namespace MCommon
{
	// Token: 0x02000028 RID: 40
	public enum KeyCode : ushort
	{
		// Token: 0x040000B2 RID: 178
		MEDIA_NEXT_TRACK = 176,
		// Token: 0x040000B3 RID: 179
		MEDIA_PLAY_PAUSE = 179,
		// Token: 0x040000B4 RID: 180
		MEDIA_PREV_TRACK = 177,
		// Token: 0x040000B5 RID: 181
		MEDIA_STOP,
		// Token: 0x040000B6 RID: 182
		ADD = 107,
		// Token: 0x040000B7 RID: 183
		MULTIPLY = 106,
		// Token: 0x040000B8 RID: 184
		DIVIDE = 111,
		// Token: 0x040000B9 RID: 185
		SUBTRACT = 109,
		// Token: 0x040000BA RID: 186
		BROWSER_BACK = 166,
		// Token: 0x040000BB RID: 187
		BROWSER_FAVORITES = 171,
		// Token: 0x040000BC RID: 188
		BROWSER_FORWARD = 167,
		// Token: 0x040000BD RID: 189
		BROWSER_HOME = 172,
		// Token: 0x040000BE RID: 190
		BROWSER_REFRESH = 168,
		// Token: 0x040000BF RID: 191
		BROWSER_SEARCH = 170,
		// Token: 0x040000C0 RID: 192
		BROWSER_STOP = 169,
		// Token: 0x040000C1 RID: 193
		NUMPAD0 = 96,
		// Token: 0x040000C2 RID: 194
		NUMPAD1,
		// Token: 0x040000C3 RID: 195
		NUMPAD2,
		// Token: 0x040000C4 RID: 196
		NUMPAD3,
		// Token: 0x040000C5 RID: 197
		NUMPAD4,
		// Token: 0x040000C6 RID: 198
		NUMPAD5,
		// Token: 0x040000C7 RID: 199
		NUMPAD6,
		// Token: 0x040000C8 RID: 200
		NUMPAD7,
		// Token: 0x040000C9 RID: 201
		NUMPAD8,
		// Token: 0x040000CA RID: 202
		NUMPAD9,
		// Token: 0x040000CB RID: 203
		F1 = 112,
		// Token: 0x040000CC RID: 204
		F10 = 121,
		// Token: 0x040000CD RID: 205
		F11,
		// Token: 0x040000CE RID: 206
		F12,
		// Token: 0x040000CF RID: 207
		F13,
		// Token: 0x040000D0 RID: 208
		F14,
		// Token: 0x040000D1 RID: 209
		F15,
		// Token: 0x040000D2 RID: 210
		F16,
		// Token: 0x040000D3 RID: 211
		F17,
		// Token: 0x040000D4 RID: 212
		F18,
		// Token: 0x040000D5 RID: 213
		F19,
		// Token: 0x040000D6 RID: 214
		F2 = 113,
		// Token: 0x040000D7 RID: 215
		F20 = 131,
		// Token: 0x040000D8 RID: 216
		F21,
		// Token: 0x040000D9 RID: 217
		F22,
		// Token: 0x040000DA RID: 218
		F23,
		// Token: 0x040000DB RID: 219
		F24,
		// Token: 0x040000DC RID: 220
		F3 = 114,
		// Token: 0x040000DD RID: 221
		F4,
		// Token: 0x040000DE RID: 222
		F5,
		// Token: 0x040000DF RID: 223
		F6,
		// Token: 0x040000E0 RID: 224
		F7,
		// Token: 0x040000E1 RID: 225
		F8,
		// Token: 0x040000E2 RID: 226
		F9,
		// Token: 0x040000E3 RID: 227
		OEM_1 = 186,
		// Token: 0x040000E4 RID: 228
		OEM_102 = 226,
		// Token: 0x040000E5 RID: 229
		OEM_2 = 191,
		// Token: 0x040000E6 RID: 230
		OEM_3,
		// Token: 0x040000E7 RID: 231
		OEM_4 = 219,
		// Token: 0x040000E8 RID: 232
		OEM_5,
		// Token: 0x040000E9 RID: 233
		OEM_6,
		// Token: 0x040000EA RID: 234
		OEM_7,
		// Token: 0x040000EB RID: 235
		OEM_8,
		// Token: 0x040000EC RID: 236
		OEM_CLEAR = 254,
		// Token: 0x040000ED RID: 237
		OEM_COMMA = 188,
		// Token: 0x040000EE RID: 238
		OEM_MINUS,
		// Token: 0x040000EF RID: 239
		OEM_PERIOD,
		// Token: 0x040000F0 RID: 240
		OEM_PLUS = 187,
		// Token: 0x040000F1 RID: 241
		KEY_0 = 48,
		// Token: 0x040000F2 RID: 242
		KEY_1,
		// Token: 0x040000F3 RID: 243
		KEY_2,
		// Token: 0x040000F4 RID: 244
		KEY_3,
		// Token: 0x040000F5 RID: 245
		KEY_4,
		// Token: 0x040000F6 RID: 246
		KEY_5,
		// Token: 0x040000F7 RID: 247
		KEY_6,
		// Token: 0x040000F8 RID: 248
		KEY_7,
		// Token: 0x040000F9 RID: 249
		KEY_8,
		// Token: 0x040000FA RID: 250
		KEY_9,
		// Token: 0x040000FB RID: 251
		KEY_A = 65,
		// Token: 0x040000FC RID: 252
		KEY_B,
		// Token: 0x040000FD RID: 253
		KEY_C,
		// Token: 0x040000FE RID: 254
		KEY_D,
		// Token: 0x040000FF RID: 255
		KEY_E,
		// Token: 0x04000100 RID: 256
		KEY_F,
		// Token: 0x04000101 RID: 257
		KEY_G,
		// Token: 0x04000102 RID: 258
		KEY_H,
		// Token: 0x04000103 RID: 259
		KEY_I,
		// Token: 0x04000104 RID: 260
		KEY_J,
		// Token: 0x04000105 RID: 261
		KEY_K,
		// Token: 0x04000106 RID: 262
		KEY_L,
		// Token: 0x04000107 RID: 263
		KEY_M,
		// Token: 0x04000108 RID: 264
		KEY_N,
		// Token: 0x04000109 RID: 265
		KEY_O,
		// Token: 0x0400010A RID: 266
		KEY_P,
		// Token: 0x0400010B RID: 267
		KEY_Q,
		// Token: 0x0400010C RID: 268
		KEY_R,
		// Token: 0x0400010D RID: 269
		KEY_S,
		// Token: 0x0400010E RID: 270
		KEY_T,
		// Token: 0x0400010F RID: 271
		KEY_U,
		// Token: 0x04000110 RID: 272
		KEY_V,
		// Token: 0x04000111 RID: 273
		KEY_W,
		// Token: 0x04000112 RID: 274
		KEY_X,
		// Token: 0x04000113 RID: 275
		KEY_Y,
		// Token: 0x04000114 RID: 276
		KEY_Z,
		// Token: 0x04000115 RID: 277
		VOLUME_DOWN = 174,
		// Token: 0x04000116 RID: 278
		VOLUME_MUTE = 173,
		// Token: 0x04000117 RID: 279
		VOLUME_UP = 175,
		// Token: 0x04000118 RID: 280
		SNAPSHOT = 44,
		// Token: 0x04000119 RID: 281
		RightClick = 93,
		// Token: 0x0400011A RID: 282
		BACKSPACE = 8,
		// Token: 0x0400011B RID: 283
		CANCEL = 3,
		// Token: 0x0400011C RID: 284
		CAPS_LOCK = 20,
		// Token: 0x0400011D RID: 285
		CONTROL = 17,
		// Token: 0x0400011E RID: 286
		ALT,
		// Token: 0x0400011F RID: 287
		DECIMAL = 110,
		// Token: 0x04000120 RID: 288
		DELETE = 46,
		// Token: 0x04000121 RID: 289
		DOWN = 40,
		// Token: 0x04000122 RID: 290
		END = 35,
		// Token: 0x04000123 RID: 291
		ESC = 27,
		// Token: 0x04000124 RID: 292
		HOME = 36,
		// Token: 0x04000125 RID: 293
		INSERT = 45,
		// Token: 0x04000126 RID: 294
		LAUNCH_APP1 = 182,
		// Token: 0x04000127 RID: 295
		LAUNCH_APP2,
		// Token: 0x04000128 RID: 296
		LAUNCH_MAIL = 180,
		// Token: 0x04000129 RID: 297
		LAUNCH_MEDIA_SELECT,
		// Token: 0x0400012A RID: 298
		LCONTROL = 162,
		// Token: 0x0400012B RID: 299
		LEFT = 37,
		// Token: 0x0400012C RID: 300
		LSHIFT = 160,
		// Token: 0x0400012D RID: 301
		LWIN = 91,
		// Token: 0x0400012E RID: 302
		PAGEDOWN = 34,
		// Token: 0x0400012F RID: 303
		NUMLOCK = 144,
		// Token: 0x04000130 RID: 304
		PAGE_UP = 33,
		// Token: 0x04000131 RID: 305
		RCONTROL = 163,
		// Token: 0x04000132 RID: 306
		ENTER = 13,
		// Token: 0x04000133 RID: 307
		RIGHT = 39,
		// Token: 0x04000134 RID: 308
		RSHIFT = 161,
		// Token: 0x04000135 RID: 309
		RWIN = 92,
		// Token: 0x04000136 RID: 310
		SHIFT = 16,
		// Token: 0x04000137 RID: 311
		SPACE_BAR = 32,
		// Token: 0x04000138 RID: 312
		TAB = 9,
		// Token: 0x04000139 RID: 313
		UP = 38
	}
}
