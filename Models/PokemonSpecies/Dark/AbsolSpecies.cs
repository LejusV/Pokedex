using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Absol Species to store common natural stats of all Absols
	#region AbsolSpecies
	public class AbsolSpecies : PokemonSpecies
	{
#nullable enable
		private static AbsolSpecies? _instance = null;
#nullable restore
        public static AbsolSpecies Instance => _instance ?? (_instance = new AbsolSpecies());

		#region AbsolSpecies Constructor
		public AbsolSpecies() : base(
			359,
			"Absol",
			Dark.Instance,
			1.2,
			47.0,
			new PokemonStats(
				65, // HPs
				130, 60, // Attack & Defense
				75, 60, // Spacial Attack & Defense
				75 // Speed
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
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Magic-Coat",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Me-First",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Charge-Beam",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Hex",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}