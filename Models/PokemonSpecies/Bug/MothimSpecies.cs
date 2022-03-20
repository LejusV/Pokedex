using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mothim Species to store common natural stats of all Mothims
	#region MothimSpecies
	public class MothimSpecies : PokemonSpecies
	{
#nullable enable
		private static MothimSpecies? _instance = null;
#nullable restore
        public static MothimSpecies Instance => _instance ?? (_instance = new MothimSpecies());

		#region MothimSpecies Constructor
		public MothimSpecies() : base(
			414,
			"Mothim",
			Bug.Instance, Flying.Instance,
			0.9,
			23.3,
			new PokemonStats(
				70, // HPs
				94, 50, // Attack & Defense
				94, 50, // Spacial Attack & Defense
				66 // Speed
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
				"Gust",
				"Tackle",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Camouflage",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion
}