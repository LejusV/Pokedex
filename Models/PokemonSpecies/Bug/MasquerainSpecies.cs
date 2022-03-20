using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Masquerain Species to store common natural stats of all Masquerains
	#region MasquerainSpecies
	public class MasquerainSpecies : PokemonSpecies
	{
#nullable enable
		private static MasquerainSpecies? _instance = null;
#nullable restore
        public static MasquerainSpecies Instance => _instance ?? (_instance = new MasquerainSpecies());

		#region MasquerainSpecies Constructor
		public MasquerainSpecies() : base(
			284,
			"Masquerain",
			Bug.Instance, Flying.Instance,
			0.8,
			3.6,
			new PokemonStats(
				70, // HPs
				60, 62, // Attack & Defense
				100, 82, // Spacial Attack & Defense
				80 // Speed
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
				"Whirlwind",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Stun-Spore",
				"String-Shot",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
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
				"Quiver-Dance",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}