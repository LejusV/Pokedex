using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seviper Species to store common natural stats of all Sevipers
	#region SeviperSpecies
	public class SeviperSpecies : PokemonSpecies
	{
#nullable enable
		private static SeviperSpecies? _instance = null;
#nullable restore
        public static SeviperSpecies Instance => _instance ?? (_instance = new SeviperSpecies());

		#region SeviperSpecies Constructor
		public SeviperSpecies() : base(
			336,
			"Seviper",
			Poison.Instance,
			2.7,
			52.5,
			new PokemonStats(
				73, // HPs
				100, 60, // Attack & Defense
				100, 60, // Spacial Attack & Defense
				65 // Speed
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
				"Swords-Dance",
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Bite",
				"Flamethrower",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Haze",
				"Lick",
				"Swift",
				"Glare",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Poison-Tail",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Wring-Out",
				"Gastro-Acid",
				"Punishment",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Switcheroo",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Round",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Dragon-Tail",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}