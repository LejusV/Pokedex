using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Deino Species to store common natural stats of all Deinos
	#region DeinoSpecies
	public class DeinoSpecies : PokemonSpecies
	{
#nullable enable
		private static DeinoSpecies? _instance = null;
#nullable restore
        public static DeinoSpecies Instance => _instance ?? (_instance = new DeinoSpecies());

		#region DeinoSpecies Constructor
		public DeinoSpecies() : base(
			633,
			"Deino",
			Dark.Instance, Dragon.Instance,
			0.8,
			17.3,
			new PokemonStats(
				52, // HPs
				65, 50, // Attack & Defense
				45, 50, // Spacial Attack & Defense
				38 // Speed
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
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Bite",
				"Roar",
				"Strength",
				"Dragon-Rage",
				"Thunder-Wave",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Shock-Wave",
				"Assurance",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Head-Smash",
				"Double-Hit",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Work-Up",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}