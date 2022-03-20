using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skuntank Species to store common natural stats of all Skuntanks
	#region SkuntankSpecies
	public class SkuntankSpecies : PokemonSpecies
	{
#nullable enable
		private static SkuntankSpecies? _instance = null;
#nullable restore
        public static SkuntankSpecies Instance => _instance ?? (_instance = new SkuntankSpecies());

		#region SkuntankSpecies Constructor
		public SkuntankSpecies() : base(
			435,
			"Skuntank",
			Poison.Instance, Dark.Instance,
			1.0,
			38.0,
			new PokemonStats(
				103, // HPs
				93, 67, // Attack & Defense
				71, 61, // Spacial Attack & Defense
				84 // Speed
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
				"Cut",
				"Headbutt",
				"Bite",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
				"Poison-Gas",
				"Explosion",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
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
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Snarl",
				"Belch",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}