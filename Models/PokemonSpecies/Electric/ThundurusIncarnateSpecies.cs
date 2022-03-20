using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Thundurus-Incarnate Species to store common natural stats of all Thundurus-Incarnates
	#region Thundurus-IncarnateSpecies
	public class ThundurusIncarnateSpecies : PokemonSpecies
	{
#nullable enable
		private static ThundurusIncarnateSpecies? _instance = null;
#nullable restore
        public static ThundurusIncarnateSpecies Instance => _instance ?? (_instance = new ThundurusIncarnateSpecies());

		#region Thundurus-IncarnateSpecies Constructor
		public ThundurusIncarnateSpecies() : base(
			642,
			"Thundurus-Incarnate",
			Electric.Instance, Flying.Instance,
			1.5,
			61.0,
			new PokemonStats(
				79, // HPs
				115, 70, // Attack & Defense
				125, 80, // Spacial Attack & Defense
				111 // Speed
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
				"Thunder-Punch",
				"Fly",
				"Thrash",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Charge",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Bulk-Up",
				"Shock-Wave",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Flash-Cannon",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Smack-Down",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}