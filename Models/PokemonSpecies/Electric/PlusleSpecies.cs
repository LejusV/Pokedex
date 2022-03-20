using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Plusle Species to store common natural stats of all Plusles
	#region PlusleSpecies
	public class PlusleSpecies : PokemonSpecies
	{
#nullable enable
		private static PlusleSpecies? _instance = null;
#nullable restore
        public static PlusleSpecies Instance => _instance ?? (_instance = new PlusleSpecies());

		#region PlusleSpecies Constructor
		public PlusleSpecies() : base(
			311,
			"Plusle",
			Electric.Instance,
			0.4,
			4.2,
			new PokemonStats(
				60, // HPs
				50, 40, // Attack & Defense
				85, 75, // Spacial Attack & Defense
				95 // Speed
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
				"Mega-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Sing",
				"Counter",
				"Seismic-Toss",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Metronome",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Wish",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Copycat",
				"Last-Resort",
				"Magnet-Rise",
				"Nasty-Plot",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Play-Nice",
				"Confide",
				"Nuzzle",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}