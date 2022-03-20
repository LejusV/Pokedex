using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lampent Species to store common natural stats of all Lampents
	#region LampentSpecies
	public class LampentSpecies : PokemonSpecies
	{
#nullable enable
		private static LampentSpecies? _instance = null;
#nullable restore
        public static LampentSpecies Instance => _instance ?? (_instance = new LampentSpecies());

		#region LampentSpecies Constructor
		public LampentSpecies() : base(
			608,
			"Lampent",
			Ghost.Instance, Fire.Instance,
			0.6,
			13.0,
			new PokemonStats(
				60, // HPs
				40, 60, // Attack & Defense
				95, 60, // Spacial Attack & Defense
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
				"Ember",
				"Flamethrower",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Minimize",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Hex",
				"Incinerate",
				"Inferno",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}