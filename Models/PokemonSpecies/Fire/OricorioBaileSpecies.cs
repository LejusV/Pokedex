using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Oricorio-Baile Species to store common natural stats of all Oricorio-Bailes
	#region Oricorio-BaileSpecies
	public class OricorioBaileSpecies : PokemonSpecies
	{
#nullable enable
		private static OricorioBaileSpecies? _instance = null;
#nullable restore
        public static OricorioBaileSpecies Instance => _instance ?? (_instance = new OricorioBaileSpecies());

		#region Oricorio-BaileSpecies Constructor
		public OricorioBaileSpecies() : base(
			741,
			"Oricorio-Baile",
			Fire.Instance, Flying.Instance,
			0.6,
			3.4,
			new PokemonStats(
				75, // HPs
				70, 70, // Attack & Defense
				98, 70, // Spacial Attack & Defense
				93 // Speed
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
				"Pound",
				"Double-Slap",
				"Swords-Dance",
				"Fly",
				"Growl",
				"Peck",
				"Toxic",
				"Agility",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Feather-Dance",
				"Teeter-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Embargo",
				"Air-Slash",
				"Captivate",
				"Round",
				"Quash",
				"Acrobatics",
				"Work-Up",
				"Hurricane",
				"Confide",
				"Revelation-Dance"
			};
		}
		#endregion
	}
	#endregion
}