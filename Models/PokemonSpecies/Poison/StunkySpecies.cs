using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stunky Species to store common natural stats of all Stunkys
	#region StunkySpecies
	public class StunkySpecies : PokemonSpecies
	{
#nullable enable
		private static StunkySpecies? _instance = null;
#nullable restore
        public static StunkySpecies Instance => _instance ?? (_instance = new StunkySpecies());

		#region StunkySpecies Constructor
		public StunkySpecies() : base(
			434,
			"Stunky",
			Poison.Instance, Dark.Instance,
			0.4,
			19.2,
			new PokemonStats(
				63, // HPs
				63, 47, // Attack & Defense
				41, 41, // Spacial Attack & Defense
				74 // Speed
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
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Focus-Energy",
				"Smog",
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
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Flame-Burst",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Snarl",
				"Belch",
				"Play-Rough",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}