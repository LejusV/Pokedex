using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tympole Species to store common natural stats of all Tympoles
	#region TympoleSpecies
	public class TympoleSpecies : PokemonSpecies
	{
#nullable enable
		private static TympoleSpecies? _instance = null;
#nullable restore
        public static TympoleSpecies Instance => _instance ?? (_instance = new TympoleSpecies());

		#region TympoleSpecies Constructor
		public TympoleSpecies() : base(
			535,
			"Tympole",
			Water.Instance,
			0.5,
			4.5,
			new PokemonStats(
				50, // HPs
				50, 40, // Attack & Defense
				50, 40, // Spacial Attack & Defense
				64 // Speed
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
				"Mist",
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
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Mud-Sport",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Aqua-Ring",
				"Earth-Power",
				"Mud-Bomb",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}