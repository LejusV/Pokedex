using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mawile Species to store common natural stats of all Mawiles
	#region MawileSpecies
	public class MawileSpecies : PokemonSpecies
	{
#nullable enable
		private static MawileSpecies? _instance = null;
#nullable restore
        public static MawileSpecies Instance => _instance ?? (_instance = new MawileSpecies());

		#region MawileSpecies Constructor
		public MawileSpecies() : base(
			303,
			"Mawile",
			Steel.Instance, Fairy.Instance,
			0.6,
			11.5,
			new PokemonStats(
				50, // HPs
				85, 85, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				50 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Vice-Grip",
				"Swords-Dance",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Growl",
				"Flamethrower",
				"Ice-Beam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Astonish",
				"Fake-Tears",
				"Rock-Tomb",
				"Tickle",
				"Iron-Defense",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Embargo",
				"Fling",
				"Guard-Swap",
				"Punishment",
				"Last-Resort",
				"Sucker-Punch",
				"Magnet-Rise",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Misty-Terrain",
				"Play-Rough",
				"Fairy-Wind",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}