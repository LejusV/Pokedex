using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blacephalon Species to store common natural stats of all Blacephalons
	#region BlacephalonSpecies
	public class BlacephalonSpecies : PokemonSpecies
	{
#nullable enable
		private static BlacephalonSpecies? _instance = null;
#nullable restore
        public static BlacephalonSpecies Instance => _instance ?? (_instance = new BlacephalonSpecies());

		#region BlacephalonSpecies Constructor
		public BlacephalonSpecies() : base(
			806,
			"Blacephalon",
			Fire.Instance, Ghost.Instance,
			1.8,
			13.0,
			new PokemonStats(
				53, // HPs
				127, 53, // Attack & Defense
				151, 79, // Spacial Attack & Defense
				107 // Speed
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
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Payback",
				"Fling",
				"Dark-Pulse",
				"Shadow-Claw",
				"Psyshock",
				"Smack-Down",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Stored-Power",
				"Quash",
				"Confide",
				"Mind-Blown"
			};
		}
		#endregion
	}
	#endregion
}