using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golett Species to store common natural stats of all Goletts
	#region GolettSpecies
	public class GolettSpecies : PokemonSpecies
	{
#nullable enable
		private static GolettSpecies? _instance = null;
#nullable restore
        public static GolettSpecies Instance => _instance ?? (_instance = new GolettSpecies());

		#region GolettSpecies Constructor
		public GolettSpecies() : base(
			622,
			"Golett",
			Ground.Instance, Ghost.Instance,
			1.0,
			92.0,
			new PokemonStats(
				59, // HPs
				74, 50, // Attack & Defense
				35, 50, // Spacial Attack & Defense
				35 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Ice-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Defense-Curl",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Magic-Coat",
				"Brick-Break",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Signal-Beam",
				"Shadow-Punch",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Gyro-Ball",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Stealth-Rock",
				"Grass-Knot",
				"Telekinesis",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}