using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ducklett Species to store common natural stats of all Duckletts
	#region DucklettSpecies
	public class DucklettSpecies : PokemonSpecies
	{
#nullable enable
		private static DucklettSpecies? _instance = null;
#nullable restore
        public static DucklettSpecies Instance => _instance ?? (_instance = new DucklettSpecies());

		#region DucklettSpecies Constructor
		public DucklettSpecies() : base(
			580,
			"Ducklett",
			Water.Instance, Flying.Instance,
			0.5,
			5.5,
			new PokemonStats(
				62, // HPs
				44, 50, // Attack & Defense
				44, 50, // Spacial Attack & Defense
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
				"Gust",
				"Wing-Attack",
				"Fly",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Mud-Sport",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Pluck",
				"Tailwind",
				"Lucky-Chant",
				"Me-First",
				"Aqua-Ring",
				"Air-Slash",
				"Brave-Bird",
				"Defog",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}