using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Palpitoad Species to store common natural stats of all Palpitoads
	#region PalpitoadSpecies
	public class PalpitoadSpecies : PokemonSpecies
	{
#nullable enable
		private static PalpitoadSpecies? _instance = null;
#nullable restore
        public static PalpitoadSpecies Instance => _instance ?? (_instance = new PalpitoadSpecies());

		#region PalpitoadSpecies Constructor
		public PalpitoadSpecies() : base(
			536,
			"Palpitoad",
			Water.Instance, Ground.Instance,
			0.8,
			17.0,
			new PokemonStats(
				75, // HPs
				65, 55, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				69 // Speed
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
				"Growl",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Gastro-Acid",
				"Aqua-Ring",
				"Earth-Power",
				"Stealth-Rock",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}