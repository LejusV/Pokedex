using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ledyba Species to store common natural stats of all Ledybas
	#region LedybaSpecies
	public class LedybaSpecies : PokemonSpecies
	{
#nullable enable
		private static LedybaSpecies? _instance = null;
#nullable restore
        public static LedybaSpecies Instance => _instance ?? (_instance = new LedybaSpecies());

		#region LedybaSpecies Constructor
		public LedybaSpecies() : base(
			165,
			"Ledyba",
			Bug.Instance, Flying.Instance,
			1.0,
			10.8,
			new PokemonStats(
				40, // HPs
				20, 30, // Attack & Defense
				40, 80, // Spacial Attack & Defense
				55 // Speed
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
				"Psybeam",
				"Counter",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Dizzy-Punch",
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
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
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