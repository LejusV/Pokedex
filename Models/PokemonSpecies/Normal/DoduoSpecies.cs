using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Doduo Species to store common natural stats of all Doduos
	#region DoduoSpecies
	public class DoduoSpecies : PokemonSpecies
	{
#nullable enable
		private static DoduoSpecies? _instance = null;
#nullable restore
        public static DoduoSpecies Instance => _instance ?? (_instance = new DoduoSpecies());

		#region DoduoSpecies Constructor
		public DoduoSpecies() : base(
			84,
			"Doduo",
			Normal.Instance, Flying.Instance,
			1.4,
			39.2,
			new PokemonStats(
				35, // HPs
				85, 45, // Attack & Defense
				35, 35, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Whirlwind",
				"Fly",
				"Jump-Kick",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Reflect",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Acupressure",
				"Assurance",
				"Brave-Bird",
				"Captivate",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}