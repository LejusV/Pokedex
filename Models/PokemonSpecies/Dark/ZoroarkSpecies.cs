using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zoroark Species to store common natural stats of all Zoroarks
	#region ZoroarkSpecies
	public class ZoroarkSpecies : PokemonSpecies
	{
#nullable enable
		private static ZoroarkSpecies? _instance = null;
#nullable restore
        public static ZoroarkSpecies Instance => _instance ?? (_instance = new ZoroarkSpecies());

		#region ZoroarkSpecies Constructor
		public ZoroarkSpecies() : base(
			571,
			"Zoroark",
			Dark.Instance,
			1.6,
			81.1,
			new PokemonStats(
				60, // HPs
				105, 60, // Attack & Defense
				120, 60, // Spacial Attack & Defense
				105 // Speed
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
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Dark-Pulse",
				"Night-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Night-Daze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}