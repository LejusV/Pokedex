using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sandile Species to store common natural stats of all Sandiles
	#region SandileSpecies
	public class SandileSpecies : PokemonSpecies
	{
#nullable enable
		private static SandileSpecies? _instance = null;
#nullable restore
        public static SandileSpecies Instance => _instance ?? (_instance = new SandileSpecies());

		#region SandileSpecies Constructor
		public SandileSpecies() : base(
			551,
			"Sandile",
			Ground.Instance, Dark.Instance,
			0.7,
			15.2,
			new PokemonStats(
				50, // HPs
				72, 35, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				65 // Speed
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
				"Cut",
				"Sand-Attack",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Counter",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Beat-Up",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Payback",
				"Assurance",
				"Embargo",
				"Me-First",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion
}