using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Greninja Specie to store common natural stats of every {'abilities': ['torrent', 'protean'], 'base_experience': 239, 'height': 15, 'id': 658, 'moves': ['pound', 'ice-punch', 'cut', 'growl', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'quick-attack', 'double-team', 'smokescreen', 'haze', 'lick', 'waterfall', 'bubble', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'spikes', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'taunt', 'role-play', 'snatch', 'secret-power', 'dive', 'hydro-cannon', 'rock-tomb', 'extrasensory', 'aerial-ace', 'bounce', 'water-pulse', 'u-turn', 'fling', 'dark-pulse', 'night-slash', 'giga-impact', 'shadow-sneak', 'gunk-shot', 'grass-knot', 'smack-down', 'round', 'echoed-voice', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'mat-block', 'confide', 'water-shuriken', 'power-up-punch', 'brutal-swing'], 'name': 'greninja', 'stats': {'hp': 72, 'attack': 95, 'defense': 67, 'special-attack': 103, 'special-defense': 71, 'speed': 122}, 'types': ['water', 'dark'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ゲッコウガ', 'ko': '개굴닌자', 'zh-Hant': '甲賀忍蛙', 'fr': 'Amphinobi', 'de': 'Quajutsu', 'es': 'Greninja', 'it': 'Greninja', 'en': 'Greninja', 'ja': 'ゲッコウガ', 'zh-Hans': '甲贺忍蛙'}, 'genera': {'ja-Hrkt': 'しのびポケモン', 'ko': '시노비포켓몬', 'zh-Hant': '忍者寶可夢', 'fr': 'Pokémon Ninja', 'de': 'Ninja', 'es': 'Pokémon Ninja', 'it': 'Pokémon Ninja', 'en': 'Ninja Pokémon', 'ja': 'しのびポケモン', 'zh-Hans': '忍者宝可梦'}}
	public class SpecieGreninja : PokemonSpecie
	{
#nullable enable
		private static SpecieGreninja? _instance = null;
#nullable restore
        public static SpecieGreninja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGreninja();
                }
                return _instance;
            }
        }

		public SpecieGreninja() : base(
			"Greninja",
			72, // HPs
			95, 67, // Attack & Defense
			103, 71, // Special Attack & Defense
			122			
		) {}
	}


	//Greninja Pokemon Class
	public class Greninja : Pokemon
	{

		public Greninja(string nickname, int level)
		: base(
				658,
				SpecieGreninja.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Greninja() : base(
			658,
			SpecieGreninja.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
	}
}