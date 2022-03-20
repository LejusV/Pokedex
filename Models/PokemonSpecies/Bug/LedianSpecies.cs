using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ledian Species to store common natural stats of all Ledians
	#region LedianSpecies
	public class LedianSpecies : PokemonSpecies
	{
#nullable enable
		private static LedianSpecies? _instance = null;
#nullable restore
        public static LedianSpecies Instance => _instance ?? (_instance = new LedianSpecies());

		#region LedianSpecies Constructor
		public LedianSpecies() : base(
			166,
			"Ledian",
			Bug.Instance, Flying.Instance,
			1.4,
			35.6,
			new PokemonStats(
				55, // HPs
				35, 50, // Attack & Defense
				55, 110, // Spacial Attack & Defense
				85 // Speed
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
				"Comet-Punch",
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Supersonic",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Air-Slash",
				"Bug-Buzz",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}