using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Beedrill Species to store common natural stats of all Beedrills
	#region BeedrillSpecies
	public class BeedrillSpecies : PokemonSpecies
	{
#nullable enable
		private static BeedrillSpecies? _instance = null;
#nullable restore
        public static BeedrillSpecies Instance => _instance ?? (_instance = new BeedrillSpecies());

		#region BeedrillSpecies Constructor
		public BeedrillSpecies() : base(
			15,
			"Beedrill",
			Bug.Instance, Poison.Instance,
			1.0,
			29.5,
			new PokemonStats(
				65, // HPs
				90, 40, // Attack & Defense
				45, 80, // Spacial Attack & Defense
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
				"Cut",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Twineedle",
				"Pin-Missile",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Assurance",
				"Toxic-Spikes",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Drill-Run",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}