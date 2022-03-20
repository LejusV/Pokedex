using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shellos Species to store common natural stats of all Shelloss
	#region ShellosSpecies
	public class ShellosSpecies : PokemonSpecies
	{
#nullable enable
		private static ShellosSpecies? _instance = null;
#nullable restore
        public static ShellosSpecies Instance => _instance ?? (_instance = new ShellosSpecies());

		#region ShellosSpecies Constructor
		public ShellosSpecies() : base(
			422,
			"Shellos",
			Water.Instance,
			0.3,
			6.3,
			new PokemonStats(
				76, // HPs
				48, 48, // Attack & Defense
				57, 62, // Spacial Attack & Defense
				34 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"String-Shot",
				"Fissure",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Sludge",
				"Amnesia",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Ancient-Power",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Memento",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Trump-Card",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}